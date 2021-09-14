using System;
using System.Collections;

namespace Program
{
  public class Personaje{
    public Personaje(string nombre, string especie){
      this.Nombre = nombre;
      this.Especie = especie;
      this.HP = 100;
    }

    private ArrayList inventario;
    private int hp;

    private int ataque;
    public int Ataque{
      get{
        return this.ataque;
      }
      set {
        this.ataque = 5 + VerAtaque(); 
      }
    }

    private int defensa;
    public int Defensa{
      get{
        return this.defensa;
      }
      set{
        this.defensa = 5 + VerDefensa();
      }
    }

    public string Nombre{get; set;}
    public string Especie{get; set;}
    public ArrayList[] Inventario{get; set;}
    public int HP{get; set;}

    public int VerAtaque(){
      int arma = 0;
      foreach (Item item in inventario){
        if(item.Tipo == "ARMA"){
          arma = item.DMG;
        }
      }
      return arma;
    }

    public int VerDefensa(){
      int def = 0;
      foreach (Item item in inventario){
        if(item.Tipo == "ARMADURA"){
          def = item.DEF;
        }
      }
      return def;
    }
  }
}