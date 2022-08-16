using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class test : MonoBehaviour
{

    void Start()
    {
        List<int> myNumbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> numbersOver5 = myNumbers.Where(n => n > 5).ToList();

        string output = "";
        foreach (var item in numbersOver5)
        {
            output += item.ToString() + ", ";
        }
        Debug.Log(output);
        output = "";

        numbersOver5[0] = 1;
        foreach (var item in numbersOver5)
        {
            output += item.ToString() + ", ";
        }
        Debug.Log(output);
        output = "";

        foreach (var item in myNumbers)
        {
            output += item.ToString() + ", ";
        }
        Debug.Log(output);
        output = "";

        List<Game> gameList = new List<Game>
        {
            new Game{name="death stranding", year=2020, score = 10},
            new Game{name="dark souls", year=2019, score = 9},
            new Game{name="cyberpunk 2077", year=2021, score = 7},
            new Game{name="bully", year=2013, score = 10},
            new Game{name="loop hero", year=2021, score = 9},
            new Game{name="valheim", year=2020, score = 10},
            new Game{name="factorio", year=2016, score = 8},
            new Game{name="mass effect 3", year=2012, score = 9}
        };

        bool allMoreThan9 = gameList.All(g => g.score >= 9);
        Debug.Log(allMoreThan9.ToString());

        List<string> gameNames = gameList.Select(g => g.name).ToList();
        foreach (var item in gameNames)
        {
            output += item + ", ";
        }
        Debug.Log(output);
        output = "";

        string firstGameScoreMoreThan9 = gameList.FirstOrDefault(g => g.score > 9).name;
        Debug.Log(firstGameScoreMoreThan9);

        List<Game> selectedGames = gameList.Where(g => g.year >= 2018 && g.score >= 8).OrderBy(g => Random.value).Take(3).ToList();
        foreach (var item in selectedGames)
        {
            output += item.name + ", ";
        }
        Debug.Log(output);
        output = "";
    }

}

public class Game
{
    public string name;
    public int year;
    public int score;
}
