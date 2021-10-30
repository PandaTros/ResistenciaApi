using System.Reflection.Metadata;
using System;
using ApiResistencia.Domain;

namespace cpiResistencia.Domain
{
    public class controller_calcular : cal_res
    {
        private string _bn1;
        private string _bn2;
        private int _bn3 = 0;
        private string _bn4;
        private double _resultado = 0.0;
        public string Calcular(string bn1, string bn2, int bn3, string bn4)
        
        {
                  _bn1 = bn1;
                  _bn2 = bn2;
                  _bn3 = bn3;
                  _bn4 = bn4;
              string aux2="";
              double aux=0.0;
            if (!(validar()))
            {
                return ("Parametros incorrectos");
            }

                int num= int.Parse(_bn1 + _bn2);

               if (_bn4=="DORADO")
               {
                    
                    if (_bn3==2)
                    {
                      _bn3=100;
                    }

                    if (_bn3 == 5)
                    {
                      _bn3 = 100000;
                     
                    }
                    if (_bn3==7)
                    {
                        _bn3 =10000000;           
                    }      
                    
                    _resultado = num * _bn3;
                    aux = (_resultado*0.05);
               }


                if (_bn4=="PLATEADO")

               {
                    
                    if (_bn3==2)
                    {  
                        _bn3=100;
                    }
                    if (_bn3 == 5)
                    {  
                        _bn3 = 100000;
                    }

                    if (_bn3==7)
                    { 
                       _bn3 =10000000;
                    }      
                        _resultado = num * _bn3;
                        aux = (_resultado*0.10);
               }
            aux2= $"Esta resistencia tiene el valor de: {_resultado} con tolerancia MAXIMA de: {_resultado + aux} y de tolerancia MINIMA de:  {_resultado - aux}";
            return aux2;
               
        }

        private bool validar ()
        {
                if (!(_bn3 == 2 || _bn3 == 5 || _bn3 ==7))
                {
                   return false;
                }

                if (!(_bn4=="PLATEADO" || _bn4 =="DORADO"))
                {
                    return false;
                }
                return true;
        }

    }
}