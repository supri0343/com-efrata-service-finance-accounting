﻿// <auto-generated />
using System;
using Com.Efrata.Service.Finance.Accounting.Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Com.Efrata.Service.Finance.Accounting.Lib.Migrations
{
    [DbContext(typeof(FinanceDbContext))]
    [Migration("20181122111112_UpdateCOATable")]
    partial class UpdateCOATable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.Efrata.Service.Finance.Accounting.Lib.Models.CreditorAccount.CreditorAccountModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<double>("BankExpenditureNoteDPP");

                    b.Property<DateTimeOffset?>("BankExpenditureNoteDate");

                    b.Property<int>("BankExpenditureNoteId");

                    b.Property<double>("BankExpenditureNoteMutation");

                    b.Property<string>("BankExpenditureNoteNo");

                    b.Property<double>("BankExpenditureNotePPN");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("CurrencyCode");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<double>("FinalBalance");

                    b.Property<string>("InvoiceNo");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<double>("MemoDPP");

                    b.Property<DateTimeOffset?>("MemoDate");

                    b.Property<double>("MemoMutation");

                    b.Property<string>("MemoNo");

                    b.Property<double>("MemoPPN");

                    b.Property<string>("SupplierCode");

                    b.Property<string>("SupplierName");

                    b.Property<double>("UnitReceiptMutation");

                    b.Property<double>("UnitReceiptNoteDPP");

                    b.Property<DateTimeOffset?>("UnitReceiptNoteDate");

                    b.Property<string>("UnitReceiptNoteNo");

                    b.Property<double>("UnitReceiptNotePPN");

                    b.HasKey("Id");

                    b.ToTable("CreditorAccounts");
                });

            modelBuilder.Entity("Com.Efrata.Service.Finance.Accounting.Lib.Models.DailyBankTransaction.BankTransactionMonthlyBalanceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountBankId")
                        .HasMaxLength(50);

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<double>("InitialBalance");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<int>("Month");

                    b.Property<double>("RemainingBalance");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("BankTransactionMonthlyBalances");
                });

            modelBuilder.Entity("Com.Efrata.Service.Finance.Accounting.Lib.Models.DailyBankTransaction.DailyBankTransactionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountBankAccountName")
                        .HasMaxLength(100);

                    b.Property<string>("AccountBankAccountNumber")
                        .HasMaxLength(100);

                    b.Property<string>("AccountBankCode")
                        .HasMaxLength(25);

                    b.Property<string>("AccountBankCurrencyCode")
                        .HasMaxLength(100);

                    b.Property<string>("AccountBankCurrencyId")
                        .HasMaxLength(50);

                    b.Property<string>("AccountBankCurrencySymbol")
                        .HasMaxLength(100);

                    b.Property<string>("AccountBankId")
                        .HasMaxLength(50);

                    b.Property<string>("AccountBankName")
                        .HasMaxLength(100);

                    b.Property<bool>("Active");

                    b.Property<double>("AfterNominal");

                    b.Property<double>("BeforeNominal");

                    b.Property<string>("BuyerCode")
                        .HasMaxLength(25);

                    b.Property<string>("BuyerId")
                        .HasMaxLength(50);

                    b.Property<string>("BuyerName")
                        .HasMaxLength(150);

                    b.Property<string>("Code")
                        .HasMaxLength(25);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<double>("Nominal");

                    b.Property<string>("ReferenceNo")
                        .HasMaxLength(50);

                    b.Property<string>("ReferenceType")
                        .HasMaxLength(50);

                    b.Property<string>("Remark")
                        .HasMaxLength(500);

                    b.Property<string>("SourceType")
                        .HasMaxLength(50);

                    b.Property<string>("Status")
                        .HasMaxLength(50);

                    b.Property<string>("SupplierCode")
                        .HasMaxLength(100);

                    b.Property<string>("SupplierId")
                        .HasMaxLength(50);

                    b.Property<string>("SupplierName")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("DailyBankTransactions");
                });

            modelBuilder.Entity("Com.Efrata.Service.Finance.Accounting.Lib.Models.JournalTransaction.JournalTransactionItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<int>("COAId");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<double>("Credit");

                    b.Property<double>("Debit");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("JournalTransactionId");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("Remark");

                    b.HasKey("Id");

                    b.HasIndex("COAId");

                    b.HasIndex("JournalTransactionId");

                    b.ToTable("JournalTransactionItems");
                });

            modelBuilder.Entity("Com.Efrata.Service.Finance.Accounting.Lib.Models.JournalTransaction.JournalTransactionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("Description");

                    b.Property<string>("DocumentNo")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("ReferenceNo")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("JournalTransactions");
                });

            modelBuilder.Entity("Com.Efrata.Service.Finance.Accounting.Lib.Models.MasterCOA.COAModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("CashAccount");

                    b.Property<string>("Code");

                    b.Property<string>("Code1");

                    b.Property<string>("Code2");

                    b.Property<string>("Code3");

                    b.Property<string>("Code4");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("Header");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("Name");

                    b.Property<string>("Nature");

                    b.Property<string>("Path");

                    b.Property<string>("ReportType");

                    b.Property<string>("Subheader");

                    b.HasKey("Id");

                    b.ToTable("ChartsOfAccounts");
                });

            modelBuilder.Entity("Com.Efrata.Service.Finance.Accounting.Lib.Models.JournalTransaction.JournalTransactionItemModel", b =>
                {
                    b.HasOne("Com.Efrata.Service.Finance.Accounting.Lib.Models.MasterCOA.COAModel", "COA")
                        .WithMany()
                        .HasForeignKey("COAId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Com.Efrata.Service.Finance.Accounting.Lib.Models.JournalTransaction.JournalTransactionModel", "JournalTransaction")
                        .WithMany("Items")
                        .HasForeignKey("JournalTransactionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
