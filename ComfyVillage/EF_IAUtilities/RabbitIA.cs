﻿using AgentUtitilies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerrainUtilities.basicStruct;

namespace IAUtilities
{
    public class RabbitIA : IIa
    {
        override public void Compute(IEnumerable<IAgent> _agents)
        {
            if (_rabbit != null)
            {
                Tree target = NearestTree(_agents.Where(i => i.GetType() == typeof(Tree)).Select(j => j as Tree));
                if (target != null)
                    MoveTo(target.Location);
            }

        }

        private Tree NearestTree(IEnumerable<Tree> trees)
        {
            Tree temp = null;
            foreach (Tree tree in trees)
            {
                if (temp == null)
                {
                    temp = tree;
                }
                if (_rabbit.Location.Distance(tree.Location) < _rabbit.Location.Distance(temp.Location))
                { 
                    temp = tree;
                }
            }
            return temp;
        }

        private void MoveTo(WorldLocation direction)
        {
            var speed = _rabbit.currentVelocity;
            var vector = direction - _rabbit.Location;

          //  var distance = direction.Distance(_rabbit.Location);
         // **  var coeff = speed / distance;

     //    **   vector = (vector / coeff);

            _rabbit.Speed.X = vector.X;
            _rabbit.Speed.Y = vector.Y;
            _rabbit.Speed.Z = vector.Z;

            
          //  Console.WriteLine(_rabbit.Speed.X + " " + _rabbit.Speed.Y + " " + _rabbit.Speed.Z);
        }


        private Rabbit _rabbit = null;

        public RabbitIA(Rabbit r)
        {
            this._rabbit = r;
        }
    }
}
