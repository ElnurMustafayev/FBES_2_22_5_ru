using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp {
    public class Menu {
        public string Name { get; set; }
        public List<Menu> Menus = new List<Menu>();

        public bool HasNext() => Menus.Count > 0;

        public void Show() {
            Console.WriteLine(Name);

            for (int i = 0; i < Menus.Count; i++) {
                Console.WriteLine(Menus[i]);
            }
        }

        public Menu Visit(int index) {
            return Menus[index];
        }
    }
}
