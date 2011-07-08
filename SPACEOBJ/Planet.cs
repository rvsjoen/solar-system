using System;
using System.Collections;
using System.Text;
using System.Xml;
using System.ComponentModel;

namespace SPACEOBJ
{
    public class Planet
    {
        // Member variables
        private String name;
        private double diameter;
        private ulong orbit;
        private String texture;
        private double inclication;
        private double orbital_speed;
        private double axialtilt;
        private double rotationvelocity;

        public ArrayList moons;

        // Constructors
        public Planet()
        {
            moons = new ArrayList();
            this.name = "";
            this.diameter = 0;
            this.orbit = 0;
            this.texture = "";
            this.rotationvelocity = 0;
            this.axialtilt = 0;
            this.orbital_speed = 0;
            this.inclication = 0;
        }

        /*
        public Planet(String name, double diameter, ulong orbit)
        {
            moons = new ArrayList();
            this.name = name;
            this.diameter = diameter;
            this.orbit = orbit;
            this.texture = "";
        }*/
        /*
        public Planet(String name, double diameter, ulong orbit, String texture)
        {
            moons = new ArrayList();
            this.name = name;
            this.diameter = diameter;
            this.orbit = orbit;
            this.texture = texture;
        }
         */

        // Properties
        public double Inclination
        {
            get
            {
                return inclication;
            }
            set
            {
                inclication = value;
            }
        }
        public double OrbitalSpeed
        {
            get
            {
                return orbital_speed;
            }
            set
            {
                orbital_speed = value;
            }
        }
        public double AxialTilt
        {
            get
            {
                return axialtilt;
            }
            set
            {
                axialtilt = value;
            }
        }
        public double Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }
        public ulong Orbit
        {
            get
            {
                return orbit;
            }
            set
            {
                orbit = value;
            }
        }
        public String Texture
        {
            get
            {
                return texture;
            }
            set
            {
                texture = value;
            }
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double RotationVelocity
        {
            get
            {
                return rotationvelocity;
            }
            set
            {
                rotationvelocity = value;
            }
        }       

        public double calculateOrbitRotation(uint time)
        {
            
            double traveled_length = time * orbital_speed;
            double circumference = Math.PI * diameter;
            double tmp = traveled_length / circumference;
            return tmp * 360;
        }

        public double calculateAxisRotation(uint time)
        {
            double traveled_length = time * rotationvelocity;
            double circumference = Math.PI * diameter;
            double tmp = traveled_length / circumference;
            return tmp * 360;
        }

        public void AddMoon(Planet p)
        {
            moons.Add(p);
        }

        public override string ToString()
        {
            return name;
        }

        // Static functions
        public static void printSolarSystem(ArrayList planets, Planet sun)
        {
            Console.WriteLine(sun.name + "\t\tDiameter: " + sun.diameter);
            foreach (Planet p in planets)
            {
                Console.WriteLine("  |--" + p);
                foreach (Planet m in p.moons)
                    Console.WriteLine("      |--" + m);
            }
        }

        public static void parseXML(String xmlfile, ArrayList planets, Planet sun)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(xmlfile);
            XmlNodeList xml_planets = xdoc.GetElementsByTagName("sun").Item(0).ChildNodes;

            IEnumerator ienum = xml_planets.GetEnumerator();
            while (ienum.MoveNext())
            {
                XmlNode p = (XmlNode)ienum.Current;
                String s = p.LocalName;
                if (s == "name")
                    sun.Name = p.InnerText;
                else if (s == "diameter")
                    sun.Diameter = double.Parse(p.InnerText, new System.Globalization.CultureInfo("en-US"));
                else if (s == "texture")
                    sun.Texture = p.InnerText;
                else if (s == "planet")
                {
                    planets.Add(parsePlanet(p));
                }
            }
        }

        public static Planet parsePlanet(XmlNode p)
        {
            IEnumerator ienum = p.GetEnumerator();
            Planet new_planet = new Planet();
            while (ienum.MoveNext())
            {
                System.Globalization.CultureInfo cuinfo = new System.Globalization.CultureInfo("en-US");

                XmlNode m = (XmlNode)ienum.Current;
                String s = m.LocalName;
                if (s == "name")
                    new_planet.Name = m.InnerText;
                else if (s == "diameter")
                    new_planet.Diameter = double.Parse(m.InnerText, cuinfo);
                else if (s == "orbit")
                    new_planet.Orbit = ulong.Parse(m.InnerText);
                else if (s == "texture")
                    new_planet.Texture = m.InnerText;
                else if (s == "orbitalspeed")
                    new_planet.OrbitalSpeed = double.Parse(m.InnerText, cuinfo);                   
                else if (s == "inclination")
                    new_planet.Inclination = double.Parse(m.InnerText, cuinfo);
                else if (s == "axialtilt")
                    new_planet.AxialTilt = double.Parse(m.InnerText, cuinfo);
                else if (s == "rotationvelocity")
                    new_planet.RotationVelocity = double.Parse(m.InnerText, cuinfo);
                else if (s == "moon")
                {
                    new_planet.AddMoon(parsePlanet(m));
                }
            }
            return new_planet;
        }
    }
}
