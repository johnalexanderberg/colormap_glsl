namespace colorScaleGen
{
    public class Scale
    {
        public readonly Note[] Notes;

        public Scale(int[] notes)
        {
            var noteArray = new Note[notes.Length];
            for (var i = 0; i < notes.Length; i++)
            {
                noteArray[i] = new Note(notes[i], i, notes.Length);
            }
            Notes = noteArray;
        }
    }
}