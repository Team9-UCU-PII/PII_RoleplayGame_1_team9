using System;
using System.Collections;

namespace Program
{
  public class Personaje
  {
    private const int K_ataqueBase = 5;
    private const int K_defensaBase = 2;
    private const int K_maxHP = 100;
    public Personaje(string nombre, string especie)
    {
      this.Nombre = nombre;
      this.Especie = especie;
      this.HP = K_maxHP;
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

    public int HP{
      get{
        return this.hp;
      }
      set{
        if(value < 0){
          this.hp = 0;
        }else {
          if (value <= K_maxHP){
            this.hp = value;
          } else{
            this.hp = K_maxHP;
          }
        }
      }
    }

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
        return arma + K_ataqueBase;
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
        return def + K_defensaBase;
      }
    }
  }
} 