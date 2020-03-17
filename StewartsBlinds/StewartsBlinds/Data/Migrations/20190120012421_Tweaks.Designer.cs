using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using StewartsBlinds.Data;

namespace StewartsBlinds.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190120012421_Tweaks")]
    partial class Tweaks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("StewartsBlinds.Data.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("AlternativeTelephone");

                    b.Property<DateTime>("AppointmentDate");

                    b.Property<string>("CompanyName");

                    b.Property<string>("County");

                    b.Property<string>("DeliveryAddress1");

                    b.Property<string>("DeliveryAddress2");

                    b.Property<string>("DeliveryCounty");

                    b.Property<string>("DeliveryPostcode");

                    b.Property<string>("DeliveryTown");

                    b.Property<string>("Email");

                    b.Property<DateTime>("FinalisedDate");

                    b.Property<bool?>("OrderPlaced");

                    b.Property<bool>("OrderSigned");

                    b.Property<string>("Postcode");

                    b.Property<double>("PriceQuoted");

                    b.Property<int>("SalesUserId");

                    b.Property<bool>("SameAsOrderAddress");

                    b.Property<bool>("SeenByFactory");

                    b.Property<bool>("SeenByOffice");

                    b.Property<string>("SpecialInstructions");

                    b.Property<string>("Surname");

                    b.Property<string>("Telephone");

                    b.Property<bool>("TermsAndConditionsLeft");

                    b.Property<string>("Title");

                    b.Property<string>("Town");

                    b.HasKey("Id");

                    b.HasIndex("SalesUserId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("StewartsBlinds.Data.Entities.ConfigurationOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FieldName");

                    b.Property<string>("Name");

                    b.Property<int>("ProductType");

                    b.HasKey("Id");

                    b.ToTable("ConfigurationOptions");
                });

            modelBuilder.Entity("StewartsBlinds.Data.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AmountPaid");

                    b.Property<int>("AppointmentId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("PaymentMethod");

                    b.Property<int>("PaymentType");

                    b.Property<string>("TakenBy");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("StewartsBlinds.Data.Entities.QuoteLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AppointmentId");

                    b.Property<string>("BeadDepth");

                    b.Property<string>("Brackets");

                    b.Property<string>("Braid");

                    b.Property<string>("Control");

                    b.Property<string>("ControlSide");

                    b.Property<string>("ControlType");

                    b.Property<string>("Controls");

                    b.Property<string>("Description");

                    b.Property<string>("Draw");

                    b.Property<string>("Drop");

                    b.Property<string>("Endcaps");

                    b.Property<string>("Fabric");

                    b.Property<string>("Finial");

                    b.Property<string>("FittingBrackets");

                    b.Property<string>("Hardware");

                    b.Property<string>("HeadrailType");

                    b.Property<string>("HoldDownBrackets");

                    b.Property<string>("HooksRequired");

                    b.Property<string>("InstallationHeight");

                    b.Property<string>("Lining");

                    b.Property<int>("NumberOfSlats");

                    b.Property<string>("PoleColour");

                    b.Property<string>("PoleSize");

                    b.Property<int>("ProductType");

                    b.Property<string>("Profile");

                    b.Property<string>("RingsRequired");

                    b.Property<string>("RoomRef");

                    b.Property<bool>("SampleRetained");

                    b.Property<string>("Scallop");

                    b.Property<string>("SizeType");

                    b.Property<string>("SlatColour");

                    b.Property<string>("SlatSize");

                    b.Property<string>("Slatting");

                    b.Property<string>("Stacking");

                    b.Property<string>("System");

                    b.Property<string>("Tape");

                    b.Property<string>("TrackColour");

                    b.Property<string>("TrackWidth");

                    b.Property<string>("TracksRequired");

                    b.Property<string>("UnderGuarantee");

                    b.Property<string>("WeightsChain");

                    b.Property<string>("Width");

                    b.Property<string>("WindowSizeRef");

                    b.Property<string>("WindowType");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.ToTable("QuoteLines");
                });

            modelBuilder.Entity("StewartsBlinds.Data.Entities.SalesUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("SalesUsers");
                });

            modelBuilder.Entity("StewartsBlinds.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("StewartsBlinds.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("StewartsBlinds.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StewartsBlinds.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StewartsBlinds.Data.Entities.Appointment", b =>
                {
                    b.HasOne("StewartsBlinds.Data.Entities.SalesUser", "SalesUser")
                        .WithMany("Appointments")
                        .HasForeignKey("SalesUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StewartsBlinds.Data.Entities.Payment", b =>
                {
                    b.HasOne("StewartsBlinds.Data.Entities.Appointment")
                        .WithMany("Payments")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StewartsBlinds.Data.Entities.QuoteLine", b =>
                {
                    b.HasOne("StewartsBlinds.Data.Entities.Appointment")
                        .WithMany("QuoteLines")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
