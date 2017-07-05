
using System.Collections.Generic;

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
        public List<Unit> timeUnits { get; set; }

        public ComboBoxData()
        {
            fillLengthUnits();
            fillMassUnits();
            fillTimeUnits();
            
            fillTypes();
        }

        void fillTypes()
        {
            unitTypes = new List<Type>();
            unitTypes.Add(new Type("Length", lengthUnits));
            unitTypes.Add(new Type("Mass", massUnits));
            unitTypes.Add(new Type("Time", timeUnits));
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

        void fillTimeUnits()
        {
            timeUnits = new List<Unit>();
            timeUnits.Add(new Unit("Nanosecond", 1000000000));
            timeUnits.Add(new Unit("Microsecond", 1000000));
            timeUnits.Add(new Unit("Millisecond", 1000));
            timeUnits.Add(new Unit("Centisecond", 100));
            timeUnits.Add(new Unit("Decisecond", 10));
            timeUnits.Add(new Unit("Second", 1));
            timeUnits.Add(new Unit("Decasecond", 0.1));
            timeUnits.Add(new Unit("Hectosecond", 0.01));
            timeUnits.Add(new Unit("Kilosecond", 0.001));
            timeUnits.Add(new Unit("Megasecond", 0.000001));
            timeUnits.Add(new Unit("Gigasecond", 0.000000001));
        }
    }

    
}
