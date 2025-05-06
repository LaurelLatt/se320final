using System.Collections.Generic;
namespace PotterFinal;
public class House
{
    public string Name { get; set; }
    public string Founder { get; set; }
    public string Mascot { get; set; }
    public List<string> Colors { get; set; }
    public List<string> Traits { get; set; }
    
    //added description
    public string Description { get; set; }

    public House(string name, string founder, string mascot, List<string> colors, List<string> traits, string description)
    {
        Name = name;
        Founder = founder;
        Mascot = mascot;
        Colors = colors;
        Traits = traits;
        Description = description; //added
    }
}

public class AdminCreateHouse
{
    //simulating database with list 
    //fake list in memory waiting for  real database
    private List<House> _houseStorage = new List<House>();

    //adds house to fake list
    public House CreateHouse(string name, string founder, string mascot, List<string> colors, List<string> traits, string description)
    {
        var house = new House(name, founder, mascot, colors, traits, description);
        _houseStorage.Add(house);//
        return house;
    }
        
    //returns all houses in fake list
    public List<House> GetHouseList()
    {
        return _houseStorage;
    }
    
    //(dont need this) but find house by name, helping updating description later
    public House GetHouseByName(string name)
    {
        return _houseStorage.Find(h => h.Name == name);
    }
}

//new class update house description
public class AdminHouseDescription
{
    private AdminCreateHouse _houseDataAccess;

    public AdminHouseDescription(AdminCreateHouse houseDataAccess)
    {
        _houseDataAccess = houseDataAccess;
    }
    
    //allow admin update description of existing house
    public bool UpdateHouseDescription(string houseName, string newDescription)
    {
        var house = _houseDataAccess.GetHouseByName(houseName);
        if (house != null)
        {
            house.Description = newDescription;
            return true;
        }

        return false; //house not found
    }
}