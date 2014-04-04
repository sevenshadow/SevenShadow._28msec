using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow._28msec.SecXbrl
{
    public enum AuthEndPoints
    {
        [Description("/_queries/public/session/login.jq")]
        Login = 0,
        [Description("/_queries/public/session/logout.jq")]
        Logout = 1,

    }

    public enum QueryEndPoints
    {
        [Description("/_queries/public/api/entities.jq")]
        Entities = 0,

        [Description("/_queries/public/api/filings.jq")]
        Filings = 1,

        [Description("/_queries/public/api/components.jq")]
        Components = 2,

        [Description("/_queries/public/api/facttable-for-component.jq")]
        FactableForComponent = 3,

        [Description("/_queries/public/api/modelstructure-for-component.jq")]
        ModelStructureForComponent = 4,

        [Description("/_queries/public/api/facts.jq")]
        Facts = 5,
        

    }

    public enum EntityGroup
    {
        [Description("DOW30")]
        Dow30 = 0,

        [Description("SP500")]
        SP500 = 1,

        [Description("FORTUNE100")]
        Fortune100 = 2,

        [Description("PJI")]
        PJI = 3,

    
    }
   

    
 
}
