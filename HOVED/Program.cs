using System;
using System.Collections;
using System.Text;
using System.Xml;
using SPACEOBJ;

namespace HOVED
{
    class Program
    {
        public const String XMLFILE = "../../../Planets.xml";
        static Planet sun = new Planet();
        static ArrayList planets = new ArrayList();

        static void Main(string[] args)
        {
            Planet.parseXML(XMLFILE, planets, sun);
            Planet.printSolarSystem(planets, sun);
            Console.Read();
        }

        /*
        static void printSolarSystem()
        {
            Console.WriteLine(sun.name + "\t\tDiameter: " + sun.diameter);
            foreach (Planet p in planets)
            {
                Console.WriteLine("  |--" + p);
                foreach (Planet m in p.moons)
                    Console.WriteLine("      |--" + m);
            }
        }

        static void parseXML()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(XMLFILE);

            XmlNodeList xml_planets = xdoc.GetElementsByTagName("sun").Item(0).ChildNodes;

            String s_name = xml_planets.Item(0).InnerText;
            double s_diameter = double.Parse(xml_planets.Item(1).InnerText, new System.Globalization.CultureInfo("en-US"));
            sun.name = s_name;
            sun.diameter = s_diameter;
            
            foreach (XmlNode p in xml_planets)
            {
                if (p.Name == "planet")
                {
                    String name = p.ChildNodes.Item(0).InnerText;
                    double diameter = double.Parse(p.ChildNodes.Item(1).InnerText, new System.Globalization.CultureInfo("en-US"));
                    ulong orbit = ulong.Parse(p.ChildNodes.Item(2).InnerText);
                    Planet new_planet = new Planet(name, diameter, orbit);
                    planets.Add(new_planet);

                    XmlNodeList xml_moons = p.ChildNodes;
                    foreach (XmlNode m in xml_moons)
                    {
                        if (m.Name == "moon")
                        {
                            String m_name = m.ChildNodes.Item(0).InnerText;
                            double m_diameter = double.Parse(m.ChildNodes.Item(1).InnerText, new System.Globalization.CultureInfo("en-US"));
                            ulong m_orbit = ulong.Parse(m.ChildNodes.Item(2).InnerText);
                            Planet new_moon = new Planet(m_name, m_diameter, m_orbit);
                            new_planet.AddMoon(new_moon);
                        }
                    }
                }
            }    
        }
         * */
    }
}
