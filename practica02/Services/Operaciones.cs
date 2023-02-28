using System;
using WSDL.mensajes;

namespace WSDL.operaciones{
    public class Operaciones : Mensajes{
        private string[] mensajes = new string[2];
 
        public string Saludar(string nombre){
            Boolean estaLleno = true;
            for(int x = 0; x < mensajes.Length; x++){
                if(string.IsNullOrEmpty(mensajes[x])){
                    mensajes[x]=nombre;
                    estaLleno = false;
                    break;
                }
            }

            if (estaLleno == true){
                return "lleno.";
            }
            return "Hola "+nombre;
        }
        public string Mostrar(int id){
            if(id >= mensajes.Length || id < 0){
                return "no hay este id";
            } 
            
            if(!string.IsNullOrEmpty(mensajes[id])){
                return "hola " + mensajes[id] ;
            }
            return "No esta este id";
        }
    }
}