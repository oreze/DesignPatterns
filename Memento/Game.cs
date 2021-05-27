using System;

namespace ConsoleApp1.Memento
{
    public class Game: Memento
    {
        public int Level { get; set; }
        public float Position { get; set; }

        private Game _quickSave { get; set; }

        public Game(int level, float position)
        {
            Level = level;
            Position = position;
        }
        
        public void CreateMemento()
        {
            _quickSave = (Game)this.MemberwiseClone();
        }

        public void RestoreMemento()
        {
            if (_quickSave != null)
            {
                Console.WriteLine("Restoring memento...");
                this.Level = _quickSave.Level;
                this.Position = _quickSave.Position;
                Console.WriteLine("Memento restored.");
            }
            else
            {
                Console.WriteLine("There`s no memento to restore.");
            }
        }
    }
}