using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;

namespace InvertedIndex_Ex1
{
    class Converter
    {
        private int counter;
        private Hashtable paths;
        private ArrayList ids;

        public Converter()
        {
            counter = 0;
            paths = new Hashtable();
            ids = new ArrayList();
        }

        public int getID(String path)
        {
            return ((int)paths[path]);
        }

        public String getPath(int id)
        {
            return ((String)ids[id]);
        }

        public int assignID(String path)
        {
            int id = counter;
            counter++;
            paths[path] = id;
            ids.Add(path);
            return (id);
        }
    }
}
