using System.Collections.Generic;
namespace PotterFinal;
public class House
{
    public string Name { get; set; }
    public string Founder { get; set; }
    public string Mascot { get; set; }
    public List<string> Colors { get; set; }
    public List<string> Traits { get; set; }

    public House(string name, string founder, string mascot, List<string> colors, List<string> traits)
    {
        Name = name;
        Founder = founder;
        Mascot = mascot;
        Colors = colors;
        Traits = traits;
    }
}

public class AdminCreateHouse
{
    //simulating database with list 
    //fake list in memory waiting for  real database
    private List<House> _houseStorage = new List<House>();

    //adds house to fake list
    public House CreateHouse(string name, string founder, string mascot, List<string> colors, List<string> traits)
    {
        var house = new House(name, founder, mascot, colors, traits);
        _houseStorage.Add(house);//
        return house;
    }
        
    //returns all houses in fake list
    public List<House> GetHouseList()
    {
        return _houseStorage;
    }
}