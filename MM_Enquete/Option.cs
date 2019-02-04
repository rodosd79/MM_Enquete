using System;
using System.IO;

namespace MM_Enquete
{
    class Option: IStorable, IEquatable<>
    {
        public string Id { set; get; }

        public string Text { set; get; }

        public void Save (BinaryWriter writer)
        {
            writer.Write(Id);
            writer.Write(Text);
        }

        public void Load(BinaryReader reader)
        {
            Id = reader.ReadString();
            Text = reader.ReadString();

        }
        
        public override bool Equals (object obj)
        {
            return Equals(obj as Option);
        }

        public bool Equals(Option other)
        {
            if (other == null)
            {
                return false;
            }
            return this.Id == other.Id;
                
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
