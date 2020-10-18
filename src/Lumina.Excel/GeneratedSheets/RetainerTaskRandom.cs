// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RetainerTaskRandom", columnHash: 0x9ab94c53 )]
    public class RetainerTaskRandom : IExcelRow
    {
        
        public SeString Name;
        public short Requirement;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< SeString >( 0 );
            Requirement = parser.ReadColumn< short >( 1 );
        }
    }
}