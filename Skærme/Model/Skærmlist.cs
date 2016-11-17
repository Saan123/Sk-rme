using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Skærme.Model
{
    public class Skærmlist : ObservableCollection<skærme>
    {
        
        public Skærmlist()
            :base()
        {
            this.Add(new skærme() { mærke = "iPhone", model = "5", farve = "sort", pris = "49kr.9" });
            this.Add(new skærme() { mærke = "iPhone", model = "6", farve = "sort", pris = "749kr." });
           
        }
        
        //sample data


        
    }
}
