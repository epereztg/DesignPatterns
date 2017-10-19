using System;
using System.Collections.Generic;

namespace TaskManagerReport
{
    class JSONReport
    {

        public void Visit(Epic epic)
        {            
            var display = "{\n type:”epic”,\n description: “Epic1 \n";
            Console.WriteLine("{0}", display);
        }

        public void Visit(Feature task)
        {            
            var display = "\t features: [\n { type: feature,\n description:" + task.name + "By: Warriors";
            Console.WriteLine("{0}", display);
        }

        public void Visit(US task)
        {            
            var display = "UserHistories: [{\n"
                          + "type: UserHistory,"
                          + "description: US1,"
                          + "historyPoints: 5"
                          + "tasks:["
                          + "{"
                          + "type:Task,"
                          + "description: T1,"
                          + "hours4"
                          + "}"
                          + "]"
                          + "}";


            Console.WriteLine("{0}", display);
        }

        public void Visit(TeamTask task)
        {
            var display = "tasks:["
            + "{"
              + "type:Task,"
              + "description: T2,"
              + "hours3"
            + "}"
            + "]";
            Console.WriteLine("{0}", display);
        }
    }
}
