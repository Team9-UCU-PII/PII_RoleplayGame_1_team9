namespace Program
{
    public class Item
    {
        public string Nombre {get;set;}
        public string Tipo {get; set;}
        
        public int DMG 
        {
            get
            {
                return this.DMG;
            } 
            set
            {
                if (this.Tipo.ToUpper() == "ARMA")
                {
                    this.DMG = value;
                }
                else
                {
                    this.DMG = 0;
                }
            }
        }
        public int DEF 
        {
            get
            {
                return this.DEF;
            } 
            set
            {
                if (this.Tipo.ToUpper() == "ARMADURA")
                {
                    this.DEF = value;
                }
                else
                {
                    this.DEF = 0;
                }
            }
        }
        
        public Item (string nombre, string tipo, int dmg, int def)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.DMG = dmg;
            this.DEF = def;

        }
    }
}