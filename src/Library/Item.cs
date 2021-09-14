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
                if (this.Tipo == "ARMA")
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
                if (this.Tipo == "ARMADURA")
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
            this.Tipo = tipo.ToUpper();
            this.DMG = dmg;
            this.DEF = def;

        }
        
         /* CrearItemsGenericos para copiar y pegar

            Item espadaStarter = new Item("Espada de Madera", "ARMA", 8, 0);
            Item espadaAvanzada = new Item("Espada de Diamante", "ARMA", 16, 0);
            Item armaduraStarter = new Item("Armadura de Cuero", "ARMADURA", 0, 9);
            Item armaduraAvanzada = new Item("Armadura de Acero", "ARMADURA", 0, 20);
         */
    }
}