using System;

namespace HaloEzAPI.Model.Response.Stats.Halo5.Arena
{
    public class ArenaPlaylistStat : PlayerMatchBreakdown
    {
        public Guid PlaylistId { get; set; }
        public int MeasurementMatchesLeft { get; set; }
        public CSR HighestCsr { get; set; }
        public CSR Csr { get; set; }
    }
}