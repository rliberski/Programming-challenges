using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001
{
    class Unit
    {
        public string name { get; set; }
        public double value { get; set; }

        public Unit(string name, double value)
        {
            this.name = name;
            this.value = value;
        }
    }

    class Type
    {
        public string type { get; set; }
        public List<Unit> list { get; set; }
    
        public Type(string type, List<Unit> list)
        {
            this.type = type;
            this.list = list;
        }
    }

    class ComboBoxData
    {
        public List<Type> unitTypes { get; set; }
        public List<Unit> lengthUnits { get; set; }
        public List<Unit> massUnits { get; set; }

        public ComboBoxData()
        {
            fillLengthUnits();
            fillMassUnits();
            
            fillTypes();
        }

        void fillTypes()
        {
            unitTypes = new List<Type>();
            unitTypes.Add(new Type("Length", lengthUnits));
            unitTypes.Add(new Type("Mass", massUnits));
        }

        void fillLengthUnits()
        {
            lengthUnits = new List<Unit>();
            lengthUnits.Add(new Unit("Nanometre", 1000000000));
            lengthUnits.Add(new Unit("Micrometre", 1000000));
            lengthUnits.Add(new Unit("Millimetre", 1000));
            lengthUnits.Add(new Unit("Centimetre", 100));
            lengthUnits.Add(new Unit("Decimetre", 10));
            lengthUnits.Add(new Unit("Metre", 1));
            lengthUnits.Add(new Unit("Decametre", 0.1));
            lengthUnits.Add(new Unit("Hectometre", 0.01));
            lengthUnits.Add(new Unit("Kilometre", 0.001));
            lengthUnits.Add(new Unit("Megametre", 0.000001));
            lengthUnits.Add(new Unit("Gigametre", 0.000000001));
            lengthUnits.Add(new Unit("Yard", 1.0936));
            lengthUnits.Add(new Unit("Inches", 39.370));
        }

        void fillMassUnits()
        {
            massUnits = new List<Unit>();
            massUnits.Add(new Unit("Nanogram",1000000000));
            massUnits.Add(new Unit("Microgram",1000000));
            massUnits.Add(new Unit("Milligram",1000));
            massUnits.Add(new Unit("Centigram",100));
            massUnits.Add(new Unit("Decigram",10));
            massUnits.Add(new Unit("Gram",1));
            massUnits.Add(new Unit("Decagram",0.1));
            massUnits.Add(new Unit("Hectogram", 0.01));
            massUnits.Add(new Unit("Kilogram", 0.001));
            massUnits.Add(new Unit("Megagram", 0.000001));
            massUnits.Add(new Unit("Gigagram", 0.000000001));
        }
    }

    
}
