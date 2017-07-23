using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Graph.Model
{
    internal class Vertex<T>
    {
        private List<int> weights;
        private T data;
        private VertexList<T> neighbours;

        #region Constructors
        public Vertex()
        {

        }

        public Vertex(T value)
        {

        }

        public Vertex(T value, VertexList<T> neighbours)
        {

        }
        #endregion

        #region Properties
        public T Value
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }

        public VertexList<T> Neighbours
        {
            get
            {
                return this.neighbours;
            }
            set
            {
                this.neighbours = value;
            }
        }

        public List<int> Weights
        {
            get
            {
                if (this.weights == null) { 
                    this.weights = new List<int>();
                }
                return this.weights;
            }
        }
        #endregion
    }
}
