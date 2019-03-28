using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nmpt.Domain
{
    public class NmtpItemConfiguration : IEntityTypeConfiguration<NmtpItem>
    {
        public void Configure(EntityTypeBuilder<NmtpItem> builder)
        {
            builder.ToTable("tbl_nmpt");

            builder.HasKey(entity => entity.IdNmtp).HasName("id_nmpt");

            builder.Property(entity => entity.IdNmtp).HasColumnName("id_nmpt");
            builder.Property(entity => entity.InNumberN).HasColumnName("in_number");
            builder.Property(entity => entity.K11n).HasColumnName("k11");
            builder.Property(entity => entity.K15n).HasColumnName("k15");
            builder.Property(entity => entity.K18n).HasColumnName("k18");
            builder.Property(entity => entity.K21n).HasColumnName("k21");
            builder.Property(entity => entity.K22n).HasColumnName("k22");
            builder.Property(entity => entity.K46n).HasColumnName("k46");
            builder.Property(entity => entity.K54n).HasColumnName("k54");
            builder.Property(entity => entity.VidTovaraN).HasColumnName("vid_tovara");
            builder.Property(entity => entity.K71n).HasColumnName("k71");
            builder.Property(entity => entity.K73n).HasColumnName("k73");
            builder.Property(entity => entity.K57n).HasColumnName("k57");
            builder.Property(entity => entity.K98n).HasColumnName("k98");
            builder.Property(entity => entity.StatusNmpt).HasColumnName("status_nmpt");
        }
    }
}
