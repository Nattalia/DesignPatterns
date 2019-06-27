using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    public class SingletonObject
    {
        // Propiedad que es del tipo de la clase singleton
        private static SingletonObject instance = new SingletonObject();

        // Propiedades internas de la clase singleton
        private string field;
        private int flag;

        // Hacemos el constructor privado, para que no se pueda instanciar esta clase
        private SingletonObject()
        {
            field = "field1";
            flag = 2;
        }

        // Obtenemos la única instancia disponible
        public static SingletonObject GetInstance()
        {
            return instance;
        }

        public string GetField()
        {
            return field;
        }

        public int GetFlag()
        {
            return flag;
        }

    }
}
