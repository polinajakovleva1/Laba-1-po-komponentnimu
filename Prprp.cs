using Newtonsoft.Json;
using System;

namespace KomponentnoeLaba1
{
    [Serializable]
    public class Prprp
    {
        [JsonProperty("nazvanie")]
        public string nazvanie { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Prprp()
        {
        }
        public Prprp(int x, int y, int z, string n)
        {
            X = x;
            Y = y;
            Z = z;
            nazvanie = n;
        }
        public Prprp(int x, int y, string n)
        {
            X = x;
            Y = y;
            nazvanie = n;
        }
        public override string ToString()
        {
            return string.Format($"{nazvanie}");
        }
    }
}
