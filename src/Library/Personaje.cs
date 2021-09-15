using System;
using System.Collections;

namespace Program
{
  public class Personaje
  {
    const int ataqueBase = 5;
    const int defensaBase = 2;
    public Personaje(string nombre, string especie)
    {
      this.Nombre = nombre;
      this.Especie = especie;
      this.HP = 100;
    }

    private int hp;

    public string Nombre{get; set;}
    public string Especie{get; set;}
    private ArrayList inventario;
    public void AddItem(Item item)
    {
      inventario.Add(item);
    }
    public void RemoveItem(Item item)
    {
      inventario.Remove(item);
    }

    public Item Arma 
    {
      get
      {
        foreach (Item item in inventario)
        {
          if(item.Tipo == "ARMA")
          {
            return item;
          }
        }
        return null;
      }
    }


    public int HP{get; set;}

    public int Ataque
    {
      get {
        int arma = 0;
        foreach (Item item in inventario)
        {
          if(item.Tipo == "ARMA")
          {
            if(arma < item.DMG){
              arma = item.DMG;
            }
          }
        }
        return arma + ataqueBase;
      }
      
    }

    public int Defensa
    {
      get{
        int def = 0;
        foreach (Item item in inventario)
        {
          if(item.Tipo == "ARMADURA")
          {
            def = item.DEF;
          }
        }
        return def + defensaBase;
      }
    }
  }
} 