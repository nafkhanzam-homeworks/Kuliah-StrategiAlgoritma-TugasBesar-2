using Microsoft.Msagl.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Stima_2
{
    public class CityGraph
    {
        public readonly Dictionary<City, List<City>> graph;
        private readonly Dictionary<KeyValuePair<City, City>, double> tr;
        public readonly Graph MSAGLGraph;
        public CityGraph()
        {
            graph = new Dictionary<City, List<City>>();
            tr = new Dictionary<KeyValuePair<City, City>, double>();
            MSAGLGraph = new Graph();
        }

        public void AddEdge(City a, City b, double p)
        {
            if (!graph.ContainsKey(a))
            {
                graph.Add(a, new List<City>());
            }
            if (!graph.ContainsKey(b))
            {
                graph.Add(b, new List<City>());
            }
            MSAGLGraph.AddEdge(a.GetName(), b.GetName());
            graph[a].Add(b);
            tr.Add(new KeyValuePair<City, City>(a, b), p);
        }

        public void Query(City root, int targetDay)
        {
            foreach (City city in graph.Keys)
            {
                city.Reset();
            }
            root.startDay = 0;
            var q = new Queue<City>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                City now = q.Dequeue();
                UpdateInfected(now);
                foreach (City next in graph[now])
                {
                    if (S(now, next, targetDay) > 1)
                    {
                        UpdateInfected(now, next);
                        int nextDay = DayPenyebaran(now, next) + now.startDay;
                        if (next.startDay <= nextDay)
                        {
                            next.startDay = nextDay;
                            q.Enqueue(next);
                        }
                    }
                }
            }
        }

        private void UpdateInfected(City city)
        {
            MSAGLGraph.FindNode(city.GetName()).Attr.FillColor = Color.OrangeRed;
        }

        private void UpdateInfected(City from, City to)
        {
            Edge e = MSAGLGraph.Edges.Where(edge => edge.Source == from.GetName() && edge.Target == to.GetName()).FirstOrDefault();
            if (e != null)
            {
                e.Attr.Color = Color.DarkRed;
            }
        }

        public double Tr(City from, City to)
        {
            return tr[new KeyValuePair<City, City>(from, to)];
        }

        public double S(City from, City to, int targetDay)
        {
            return from.I(targetDay) * Tr(from, to);
        }

        public int DayPenyebaran(City from, City to)
        {
            double d = 20d / (double)(from.P() * Tr(from, to));
            int next = (int)Math.Ceiling(d);
            if (next == d)
            {
                ++next;
            }
            return next;
        }
    }
}
