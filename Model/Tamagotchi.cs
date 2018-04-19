using System.Collections.Generic;
using System.IO;
using System;

namespace Tamagotchi.Models
{
  public class Pet
  {
    private string _name;
    private int _food;
    private int _attention;
    private int _sleep;
    private bool _alive;
    private static List<Pet> _pets = new List<Pet> {};

    public Pet(string name)
    {
      _name=name;
      _food=100;
      _attention=100;
      _sleep=100;
      _alive=true;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public int GetFood()
    {
      return _food;
    }
    public void SetFood(int newFood)
    {
      _food = newFood;
    }
    public int GetAttention()
    {
      return _attention;
    }
    public void SetAttention(int newAttention)
    {
      _attention = newAttention;
    }
    public int GetSleep()
    {
      return _sleep;
    }
    public void SetSleep(int newSleep)
    {
      _sleep=newSleep;
    }
    public bool GetAlive()
    {
      return _alive;
    }
    public void SetAlive(bool newAlive)
    {
      _alive=newAlive;
    }
    public static List<Pet> GetAll()
    {
      return _pets;
    }
    public void Save()
    {
      _pets.Add(this);
    }
    // public void IntervalHP(int fun){
    //   for(var i =0 ; i < fun; i ++){
    //     //SetInterval
    //     this.SetFood(this.GetFood()-1);
    //   }
    // }
    public void PassTime()
    {
      this.SetFood(this.GetFood()-10);
      this.SetAttention(this.GetAttention()-10);
      this.SetSleep(this.GetSleep()-10);
    }

    // public static Pet Find(int searchId)
    // {
    //   return _pets[searchId-1];
    // }
  }
}
