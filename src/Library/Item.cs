namespace Program
{
    public class Item
    {
        private string nombre;
        private string tipo;
        private int dmg;
        private int def;

        
        public string Nombre {get;set;}
        public string Tipo 
        {
            get
            {
                return this.tipo;
            }
            set
            {
                if ((value.ToUpper() == "ARMA") || (value.ToUpper() == "ARMADURA"))
                {
                    this.tipo = value.ToUpper();
                }
                else
                {
                    {
                        this.tipo = null;
                    }
                }
            }
        }
        
        public int DMG 
        {
            get
            {
                return this.dmg;
            } 
            set
            {
                if (this.Tipo == "ARMA")
                {
                    this.dmg = value;
                }
                else
                {
                    this.dmg = 0;
                }
            }
        }
        public int DEF 
        {
            get
            {
                return this.def;
            } 
            set
            {
                if (this.Tipo == "ARMADURA")
                {
                    this.def = value;
                }
                else
                {
                    this.def = 0;
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
        
         /* CrearItemsGenericos para copiar y pegar

            Item espadaStarter = new Item("Espada de Madera", "ARMA", 8, 0);
            Item espadaAvanzada = new Item("Espada de Diamante", "ARMA", 16, 0);
            Item armaduraStarter = new Item("Armadura de Cuero", "ARMADURA", 0, 4);
            Item armaduraAvanzada = new Item("Armadura de Acero", "ARMADURA", 0, 8);
         */
    }
}