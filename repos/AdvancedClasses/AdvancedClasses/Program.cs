using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

    }
    abstract class Base //Base class that acts as the base for the other classes to inherit
    {
        //Creating the base variables that all of the classes in this Class Library will inherit
        public double hp;        
        public string navn;        
        public ushort range;

        //Creating the base method that all of the classes in this Class Library will inherit
        public virtual void Move()
        {

        }       
    }

    abstract class Champion : Base //Inherits from the base class while adding special things for this catagory of class
    {
        //Creating new variables that are specific to the champion class
        public double mana = 50;
        public byte lvl = 1;
        //Creating new methods that are specefic to the champion class
        public virtual void CastSpell()
        {

        }

        public void GainXp()
        {

        }
    }

    class Veigar : Champion //A League of legends Champion which inherits the champion class
    {
        //Polymorphing the variables that needed to be changed, for this class only
        public new double hp = 100;
        public new string navn = "Veigar";
        public new ushort range = 200;
        public new double mana = 100;

        //Polymorping the methods that needed to be changed for this class only
        public override void Move()
        {

        }
        public new void CastSpell()
        {

        }
        public new void GainXp()
        {

        }
    }

    class Lulu : Champion
    {
        //Polymorphing the variables that needed to be changed, for this class only
        public new double hp = 100;
        public new string navn = "Lulu";
        public new ushort range = 300;
        public new double mana = 200;

        //Polymorping the methods that needed to be changed for this class only
        public new void Move()
        {

        }
        public new void CastSpell()
        {

        }
        public new void GainXp()
        {

        }
    }

    class Kayn : Champion
    {
        //Polymorphing the variables that needed to be changed, for this class only
        public new double hp = 200;
        public new string navn = "Kayn";
        public new ushort range = 400;
        public new double mana = 120;

        //Polymorping the methods that needed to be changed for this class only
        public new void Move()
        {

        }
        public new void CastSpell()
        {

        }
        public new void GainXp()
        {

        }
    }

    class Akali : Champion
    {
        //Polymorphing the variables that needed to be changed, for this class only
        public new double hp = 50;
        public new string navn = "Akali";
        public new ushort range = 200;
        public new double mana = 300;

        //Polymorping the methods that needed to be changed for this class only
        public new void Move()
        {

        }
        public new void CastSpell()
        {

        }
        public new void GainXp()
        {

        }
    }

    class Khazix : Champion
    {
        //Polymorphing the variables that needed to be changed, for this class only
        public new double hp = 200;
        public new string navn = "Khazix";
        public new ushort range = 200;
        public new double mana = 300;

        //Polymorping the methods that needed to be changed for this class only
        public new void Move()
        {

        }
        public new void CastSpell()
        {

        }
        public new void GainXp()
        {

        }
    }

    class Minions : Base
    {
        //Polymorphing the variables that needed to be changed, for this class only
        public new double hp = 100;
        public new string navn = "Attack Minion";
        public new ushort range = 200;

        //Polymorping the methods that needed to be changed for this class only
        public new void Move()
        {

        }
    }

    class Grump : Base
    {
        //Polymorphing the variables that needed to be changed, for this class only
        public new double hp = 100;
        public new string navn = "Grump";
        public new ushort range = 200;

        //Polymorping the methods that needed to be changed for this class only
        public new void Move()
        {

        }
    }

    class Player : Champion
    {
        //Polymorping the methods that needed to be changed for this class only
        public new void Move()
        {

        }
        public new void CastSpell()
        {

        }
        public new void GainXp()
        {

        }
    }
}
