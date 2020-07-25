﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Src
{
    public class Layer
    {
        public double LearningRate { get; }
        private string LayerName { get; }
        public List<Node> LayerNodes { get; }

        public Layer(double learn_rate, string name = "")
        {
            this.LearningRate = learn_rate;
            this.LayerName = name;
            this.LayerNodes = new List<Node>();
        }

        public void Forward()
        {
            foreach (var node in LayerNodes)
            {
                node.Calculate();
            }
        }

        public void Backward()
        {
            foreach (var node in LayerNodes)
            {
                node.Derive(this.LearningRate);
            }
        }

        public void AddNode(Node targetNode)
        {
            this.LayerNodes.Add(targetNode);
        }

        public override string ToString()
        {
            return this.LayerName;
        }
    }
}