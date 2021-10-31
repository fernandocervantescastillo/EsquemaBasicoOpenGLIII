using Newtonsoft.Json;
using OpenGL.common;
using System;
using System.Collections.Generic;

namespace OpenGL.model
{
    [Serializable()]
    class Objeto
    {

        public List<Cara> list;

        public Objeto()
        {
            list = new List<Cara>();
        }

        public Objeto(string JSON)
        {
            Objeto obj1 = JsonConvert.DeserializeObject<Objeto>(JSON);
            this.list = obj1.list;
        }

        public void addCara(Cara cara)
        {
            list.Add(cara);
        }

        public Cara getCara(int i)
        {
            return list[i];
        }

        public int countCaras()
        {
            return list.Count;
        }

        public void render(Camera _camera)
        {
            foreach (Cara cara in list)
            {
                cara.render(0, _camera);
            }
        }

        public void dispose()
        {
            foreach (Cara cara in list)
            {
                cara.dispose();
            }

        }

        public string toJSON()
        {
            string text = JsonConvert.SerializeObject(this, Formatting.Indented);
            return text;
        }


    }
}

