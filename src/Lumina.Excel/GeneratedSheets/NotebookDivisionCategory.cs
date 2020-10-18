// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NotebookDivisionCategory", columnHash: 0x9ff65ad6 )]
    public class NotebookDivisionCategory : IExcelRow
    {
        
        public SeString Name;
        public byte Index;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< SeString >( 0 );
            Index = parser.ReadColumn< byte >( 1 );
        }
    }
}