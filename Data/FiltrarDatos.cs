using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesTipoVista.Data
{
    public class FiltrarDatos :BindableObject
    {
        public static readonly BindableProperty FilterProperty =
            BindableProperty.Create(nameof(Filter), typeof(string), typeof(FiltrarDatos), null);

        public string Filter
        {
            get {  return (string)GetValue(FilterProperty); }
            set { SetValue(FilterProperty, value);}
            
        }
    }
}
