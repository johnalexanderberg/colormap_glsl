using System;

namespace colorScaleGen
{
    public class Note
    {
        public int Value;
        public double NoteWeight;
        
        public Note(int indexChromatic, int indexScale, int notesInScale)
        {
            Value = indexChromatic;
            NoteWeight = (Convert.ToDouble(notesInScale) - Convert.ToDouble(indexScale)) / Convert.ToDouble(notesInScale);
        }
    }
}