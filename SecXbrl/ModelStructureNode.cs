using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow._28msec.SecXbrl
{

    public class ModelStructureNode
    {
      public string Kind { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public bool IsNillable { get; set; }
        public bool IsAbstract { get; set; }
        public string PeriodType { get; set; }
        public string Balance { get; set; }
        public string SubstitutionGroup { get; set; }
        public string DataType { get; set; }
        public string BaseType { get; set; }
        public string ClosestSchemaBuiltinType { get; set; }
        public bool IsTextBlock { get; set; }
        public int Level { get; set; }

        public List<ModelStructureNode> Children { get; set; }
        
    }
}
