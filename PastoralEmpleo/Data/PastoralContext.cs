
using Microsoft.EntityFrameworkCore;
using PastoralEmpleo.Models;

namespace PastoralEmpleo.Data
{
    public partial class PastoralContext : DbContext
    {
        public PastoralContext()
        {
        }

        public PastoralContext(DbContextOptions<PastoralContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Academicstate> Academicstate { get; set; }
        public virtual DbSet<Candidate> Candidate { get; set; }
        public virtual DbSet<Civilstatus> Civilstatus { get; set; }
        public virtual DbSet<Contracttype> Contracttype { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<Documenttype> Documenttype { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Periodicity> Periodicity { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Studies> Studies { get; set; }
        public virtual DbSet<Studylevel> Studylevel { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Waytopay> Waytopay { get; set; }
        public virtual DbSet<Workstatus> Workstatus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("database=announcement;server=localhost;port=3306;user id=root;password=Samysanty1626");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Academicstate>(entity =>
            {
                entity.HasKey(e => e.Idacademicstate);

                entity.ToTable("academicstate", "announcement");

                entity.Property(e => e.Idacademicstate)
                    .HasColumnName("idacademicstate")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.HasKey(e => e.Idcandidate);

                entity.ToTable("candidate", "announcement");

                entity.HasIndex(e => e.Idcivilstatus)
                    .HasName("fk_candidate_civilstatus_id_idx");

                entity.HasIndex(e => e.Iddocumenttype)
                    .HasName("fk_candidate_documenttype_id");

                entity.HasIndex(e => e.Idgender)
                    .HasName("fk_candidate_gender_id_idx");

                entity.HasIndex(e => e.Iduser)
                    .HasName("iduser_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Idcandidate)
                    .HasColumnName("idcandidate")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Brithdate)
                    .HasColumnName("brithdate")
                    .HasColumnType("date");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasColumnName("district")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idcivilstatus)
                    .HasColumnName("idcivilstatus")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Iddocumenttype)
                    .HasColumnName("iddocumenttype")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Identitydocumento)
                    .IsRequired()
                    .HasColumnName("identitydocumento")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Idgender)
                    .HasColumnName("idgender")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Iduser)
                    .HasColumnName("iduser")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("mail")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Municipality)
                    .IsRequired()
                    .HasColumnName("municipality")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("surname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasColumnName("telephone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdcivilstatusNavigation)
                    .WithMany(p => p.Candidate)
                    .HasForeignKey(d => d.Idcivilstatus)
                    .HasConstraintName("fk_candidate_civilstatus_id");

                entity.HasOne(d => d.IddocumenttypeNavigation)
                    .WithMany(p => p.Candidate)
                    .HasForeignKey(d => d.Iddocumenttype)
                    .HasConstraintName("fk_candidate_documenttype_id");

                entity.HasOne(d => d.IdgenderNavigation)
                    .WithMany(p => p.Candidate)
                    .HasForeignKey(d => d.Idgender)
                    .HasConstraintName("fk_candidate_gender_id");

                entity.HasOne(d => d.IduserNavigation)
                    .WithOne(p => p.Candidate)
                    .HasForeignKey<Candidate>(d => d.Iduser)
                    .HasConstraintName("fk_candidate_user_id");
            });

            modelBuilder.Entity<Civilstatus>(entity =>
            {
                entity.HasKey(e => e.Idcivilstatus);

                entity.ToTable("civilstatus", "announcement");

                entity.Property(e => e.Idcivilstatus)
                    .HasColumnName("idcivilstatus")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.Idrole);

                entity.ToTable("role", "announcement");

                entity.Property(e => e.Idrole)
                    .HasColumnName("idrole")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasKey(e => e.Idpermission);

                entity.ToTable("permission", "announcement");

                entity.Property(e => e.Idpermission)
                    .HasColumnName("idpermission")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.HasKey(pc => new { pc.Idrole, pc.Idpermission });

                entity.HasOne(e => e.Role)
                    .WithMany(e => e.RolePermission)
                    .HasForeignKey(e => e.Idrole);

                entity.HasOne(e => e.Permission)
                    .WithMany(e => e.RolePermission)
                    .HasForeignKey(e => e.Idpermission);
            });

            modelBuilder.Entity<Contracttype>(entity =>
            {
                entity.HasKey(e => e.Idcontracttype);

                entity.ToTable("contracttype", "announcement");

                entity.Property(e => e.Idcontracttype)
                    .HasColumnName("idcontracttype")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.Iddocument);

                entity.ToTable("document", "announcement");

                entity.HasIndex(e => e.Iddocumenttype)
                    .HasName("iddocument_documenttype_id_idx");

                entity.Property(e => e.Iddocument)
                    .HasColumnName("iddocument")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idcandidate)
                    .HasColumnName("idcandidate")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Iddocumenttype)
                    .HasColumnName("iddocumenttype")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdcandidateNavigation)
                    .WithOne(p => p.Document)
                    .HasForeignKey<Document>(d => d.Idcandidate)
                    .HasConstraintName("fk_document_candidate_id");

                entity.HasOne(d => d.IddocumenttypeNavigation)
                    .WithMany(p => p.Document)
                    .HasForeignKey(d => d.Iddocumenttype)
                    .HasConstraintName("fk_document_documenttype_id");
            });

            modelBuilder.Entity<Documenttype>(entity =>
            {
                entity.HasKey(e => e.Iddocumenttype);

                entity.ToTable("documenttype", "announcement");

                entity.Property(e => e.Iddocumenttype)
                    .HasColumnName("iddocumenttype")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubType)
                    .HasColumnName("subtype")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.Idevent);

                entity.ToTable("event", "announcement");

                entity.HasIndex(e => e.Idcontracttype)
                    .HasName("fk_event_contracttype_id");

                entity.HasIndex(e => e.Idwaytopay)
                    .HasName("fk_event_waytopay_id_idx");

                entity.HasIndex(e => e.Idstatus)
                   .HasName("fk_event_status_id_idx");

                entity.Property(e => e.Idevent)
                    .HasColumnName("idevent")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Endeventdate)
                    .HasColumnName("endeventdate")
                    .HasColumnType("date");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Endjobtime)
                    .HasColumnName("endjobtime")
                    .HasColumnType("Time");

                entity.Property(e => e.Experience)
                    .IsRequired()
                    .HasColumnName("experience")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Functions)
                    .IsRequired()
                    .HasColumnName("functions")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Idcontracttype)
                    .HasColumnName("idcontracttype")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idstatus)
                    .HasColumnName("idstatus")
                    .HasColumnType("int(11)");


                entity.Property(e => e.Idwaytopay)
                    .HasColumnName("idwaytopay")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Initialeventdate)
                    .HasColumnName("initialeventdate")
                    .HasColumnType("date");

                entity.Property(e => e.Initialjobetime)
                    .HasColumnName("initialjobetime")
                    .HasColumnType("Time");

                entity.Property(e => e.Laboraltime)
                    .IsRequired()
                    .HasColumnName("laboraltime")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Callnumber)
                    .HasColumnName("callnumber")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Observations)
                    .IsRequired()
                    .HasColumnName("observations")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasColumnName("place")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasColumnName("position")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasColumnName("product")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Salary)
                    .HasColumnName("salary")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Study)
                    .IsRequired()
                    .HasColumnName("study")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Vacant)
                    .HasColumnName("vacant")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdcontracttypeNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.Idcontracttype)
                    .HasConstraintName("fk_event_contracttype_id");

                entity.HasOne(d => d.IdstatusNavigation)
                   .WithMany(p => p.Event)
                   .HasForeignKey(d => d.Idstatus)
                   .HasConstraintName("fk_event_status_id");

                entity.HasOne(d => d.IdwaytopayNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.Idwaytopay)
                    .HasConstraintName("fk_event_waytopay_id");
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.HasKey(e => e.Idexperience);

                entity.ToTable("experience", "announcement");

                entity.HasIndex(e => e.Idworkstatus)
                    .HasName("fk_experience_workstatus_id_idx");

                entity.HasIndex(e => e.Idcandidate)
                    .HasName("fk_experience_candidate_id_idx");

                entity.Property(e => e.Idexperience)
                    .HasColumnName("idexperience")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Companyname)
                    .IsRequired()
                    .HasColumnName("companyname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Endperiod)
                    .HasColumnName("endperiod")
                    .HasColumnType("date");

                entity.Property(e => e.Idcandidate)
                    .HasColumnName("idcandidate")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idworkstatus)
                    .HasColumnName("idworkstatus")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Initialperiod)
                    .HasColumnName("initialperiod")
                    .HasColumnType("date");

                entity.Property(e => e.Inmediateboss)
                    .IsRequired()
                    .HasColumnName("inmediateboss")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Inmediatechiefnumbre)
                    .IsRequired()
                    .HasColumnName("inmediatechiefnumbre")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasColumnName("position")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdcandidateNavigation)
                    .WithOne(p => p.Experience)
                    .HasForeignKey<Experience>(d => d.Idcandidate)
                    .HasConstraintName("fk_experience_candidate_id");

                entity.HasOne(d => d.IdworkstatusNavigation)
                    .WithMany(p => p.Experience)
                    .HasForeignKey(d => d.Idworkstatus)
                    .HasConstraintName("fk_experience_workstatus_id");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasKey(e => e.Idgender);

                entity.ToTable("gender", "announcement");

                entity.Property(e => e.Idgender)
                    .HasColumnName("idgender")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Periodicity>(entity =>
            {
                entity.HasKey(e => e.Idperiodicity);

                entity.ToTable("periodicity", "announcement");

                entity.Property(e => e.Idperiodicity)
                    .HasColumnName("idperiodicity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.Idstatus);

                entity.ToTable("status", "announcement");

                entity.Property(e => e.Idstatus)
                    .HasColumnName("idstatus")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Studies>(entity =>
            {
                entity.HasKey(e => e.Idstudies);

                entity.ToTable("studies", "announcement");

                entity.HasIndex(e => e.Idacademicstate)
                    .HasName("fk_studies_academicstate_id_idx");

                entity.HasIndex(e => e.Idcandidate)
                    .HasName("idcandidate_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Idperiodicity)
                    .HasName("fk_studies_periodicity_id_idx");

                entity.HasIndex(e => e.Idstudylevel)
                    .HasName("fk_studies_studylevel_id_idx");

                entity.Property(e => e.Idstudies)
                    .HasColumnName("idstudies")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("date");

                entity.Property(e => e.Idacademicstate)
                    .HasColumnName("idacademicstate")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idcandidate)
                    .HasColumnName("idcandidate")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idperiodicity)
                    .HasColumnName("idperiodicity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idstudylevel)
                    .HasColumnName("idstudylevel")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Obtainedtitle)
                    .IsRequired()
                    .HasColumnName("obtainedtitle")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.School)
                    .IsRequired()
                    .HasColumnName("school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date");

                entity.HasOne(d => d.IdacademicstateNavigation)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.Idacademicstate)
                    .HasConstraintName("fk_studies_academicstate_id");

                entity.HasOne(d => d.IdcandidateNavigation)
                    .WithOne(p => p.Studies)
                    .HasForeignKey<Studies>(d => d.Idcandidate)
                    .HasConstraintName("fk_studies_candidate_id");

                entity.HasOne(d => d.IdperiodicityNavigation)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.Idperiodicity)
                    .HasConstraintName("fk_studies_periodicity_id");

                entity.HasOne(d => d.IdstudylevelNavigation)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.Idstudylevel)
                    .HasConstraintName("fk_studies_studylevel_id");
            });

            modelBuilder.Entity<Studylevel>(entity =>
            {
                entity.HasKey(e => e.Idstudylevel);

                entity.ToTable("studylevel", "announcement");

                entity.Property(e => e.Idstudylevel)
                    .HasColumnName("idstudylevel")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Iduser);

                entity.ToTable("user", "announcement");

                entity.Property(e => e.Iduser)
                    .HasColumnName("iduser")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("mail")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("surname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdRole)
                    .HasColumnName("idrole")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Waytopay>(entity =>
            {
                entity.HasKey(e => e.Idwaytopay);

                entity.ToTable("waytopay", "announcement");

                entity.Property(e => e.Idwaytopay)
                    .HasColumnName("idwaytopay")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Workstatus>(entity =>
            {
                entity.HasKey(e => e.Idworkstatus);

                entity.ToTable("workstatus", "announcement");

                entity.Property(e => e.Idworkstatus)
                    .HasColumnName("idworkstatus")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });
        }
    }
}
