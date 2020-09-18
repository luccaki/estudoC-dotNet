using System;
using System.Collections.Generic;
using System.Text;

namespace Conjuntos.Entities
{
    class Aluno
    {
        public int Id { get; private set; }
        public char Course { get; private set; }

        public Aluno(int id, char course)
        {
            Id = id;
            Course = course;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Aluno))
            {
                return false;
            }
            Aluno other = obj as Aluno;
            return Id.Equals(other.Id);
        }
    }
}
