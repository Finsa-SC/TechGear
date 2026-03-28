-- ============================================================
--  TechGear17 - Database Setup Script
--  Compatible with: SQL Server 2016+ / SQL Server Express
--
--  This script will:
--    1. Create the database (TechGearDatabase)
--    2. Create all required tables
--    3. Insert seed / sample data
-- ============================================================

-- ── 1. DATABASE ──────────────────────────────────────────────
IF NOT EXISTS (
    SELECT name FROM sys.databases WHERE name = 'TechGearDatabase'
)
BEGIN
    CREATE DATABASE TechGearDatabase;
    PRINT 'Database [TechGearDatabase] created.';
END
ELSE
    PRINT 'Database [TechGearDatabase] already exists — skipping creation.';
GO

USE TechGearDatabase;
GO

-- ── 2. TABLES ────────────────────────────────────────────────

-- Categories
IF OBJECT_ID('Categories', 'U') IS NULL
BEGIN
    CREATE TABLE Categories (
        CategoryId   INT           NOT NULL IDENTITY(1,1),
        CategoryName NVARCHAR(100) NOT NULL,

        CONSTRAINT PK_Categories PRIMARY KEY (CategoryId)
    );
    PRINT 'Table [Categories] created.';
END
GO

-- Items
IF OBJECT_ID('Items', 'U') IS NULL
BEGIN
    CREATE TABLE Items (
        ItemId     INT            NOT NULL IDENTITY(1,1),
        CategoryId INT            NOT NULL,
        ItemName   NVARCHAR(150)  NOT NULL,
        Stock      INT            NOT NULL DEFAULT 0,
        Price      DECIMAL(18, 2) NOT NULL DEFAULT 0,

        CONSTRAINT PK_Items       PRIMARY KEY (ItemId),
        CONSTRAINT FK_Items_Cat   FOREIGN KEY (CategoryId)
            REFERENCES Categories (CategoryId)
    );
    PRINT 'Table [Items] created.';
END
GO

-- Service
IF OBJECT_ID('Service', 'U') IS NULL
BEGIN
    CREATE TABLE Service (
        ServiceId     INT           NOT NULL IDENTITY(1,1),
        CustomerName  NVARCHAR(150) NOT NULL,
        DamageType    NVARCHAR(500) NOT NULL,
        EntryDate     DATETIME      NOT NULL DEFAULT GETDATE(),
        ServiceStatus NVARCHAR(50)  NOT NULL DEFAULT 'Waiting',
        Phone         NVARCHAR(20)  NULL,

        CONSTRAINT PK_Service PRIMARY KEY (ServiceId),
        CONSTRAINT CK_Service_Status CHECK (
            ServiceStatus IN ('Waiting', 'In Process', 'Done')
        )
    );
    PRINT 'Table [Service] created.';
END
GO

-- ServiceDetail
IF OBJECT_ID('ServiceDetail', 'U') IS NULL
BEGIN
    CREATE TABLE ServiceDetail (
        DetailId  INT            NOT NULL IDENTITY(1,1),
        ServiceId INT            NOT NULL,
        ItemId    INT            NOT NULL,
        Qty       INT            NOT NULL DEFAULT 1,
        Price     DECIMAL(18, 2) NOT NULL DEFAULT 0,
        Subtotal  DECIMAL(18, 2) NOT NULL DEFAULT 0,

        CONSTRAINT PK_ServiceDetail          PRIMARY KEY (DetailId),
        CONSTRAINT FK_ServiceDetail_Service  FOREIGN KEY (ServiceId)
            REFERENCES Service (ServiceId),
        CONSTRAINT FK_ServiceDetail_Item     FOREIGN KEY (ItemId)
            REFERENCES Items (ItemId)
    );
    PRINT 'Table [ServiceDetail] created.';
END
GO

-- TransactionService
IF OBJECT_ID('TransactionService', 'U') IS NULL
BEGIN
    CREATE TABLE TransactionService (
        TransactionId   INT            NOT NULL IDENTITY(1,1),
        ServiceId       INT            NOT NULL,
        SubTotal        DECIMAL(18, 2) NOT NULL DEFAULT 0,
        TransactionDate DATETIME       NOT NULL DEFAULT GETDATE(),

        CONSTRAINT PK_TransactionService        PRIMARY KEY (TransactionId),
        CONSTRAINT FK_TransactionService_Service FOREIGN KEY (ServiceId)
            REFERENCES Service (ServiceId)
    );
    PRINT 'Table [TransactionService] created.';
END
GO

-- ── 3. SEED DATA ─────────────────────────────────────────────
--  Wrapped in IF NOT EXISTS guards so the script is safe to re-run.

-- Categories
IF NOT EXISTS (SELECT 1 FROM Categories)
BEGIN
    SET IDENTITY_INSERT Categories ON;

    INSERT INTO Categories (CategoryId, CategoryName) VALUES
        (1, 'Processor'),
        (2, 'Memory (RAM)'),
        (3, 'Storage'),
        (4, 'Motherboard'),
        (5, 'GPU / Graphics Card'),
        (6, 'Cooling System'),
        (7, 'Power Supply'),
        (8, 'Peripherals'),
        (9, 'Cables & Adapters'),
        (10, 'Tools & Consumables');

    SET IDENTITY_INSERT Categories OFF;
    PRINT 'Seed data inserted into [Categories].';
END
GO

-- Items
IF NOT EXISTS (SELECT 1 FROM Items)
BEGIN
    SET IDENTITY_INSERT Items ON;

    INSERT INTO Items (ItemId, CategoryId, ItemName, Stock, Price) VALUES
        -- Processor
        (1,  1, 'Intel Core i5-12400',          8,  210.00),
        (2,  1, 'Intel Core i7-13700K',          5,  390.00),
        (3,  1, 'AMD Ryzen 5 5600X',             10, 185.00),
        (4,  1, 'AMD Ryzen 7 7700X',             4,  340.00),

        -- Memory (RAM)
        (5,  2, 'Corsair Vengeance 8GB DDR4',    15,  32.00),
        (6,  2, 'G.Skill Ripjaws 16GB DDR4',     12,  55.00),
        (7,  2, 'Kingston Fury 32GB DDR5',        6,  110.00),

        -- Storage
        (8,  3, 'Samsung 870 EVO 500GB SSD',      9,  65.00),
        (9,  3, 'WD Blue 1TB HDD',               14,  45.00),
        (10, 3, 'Kingston NV2 1TB NVMe SSD',      7,  75.00),

        -- Motherboard
        (11, 4, 'ASUS Prime B660M-A',             3, 130.00),
        (12, 4, 'MSI MAG B550 TOMAHAWK',          3, 155.00),
        (13, 4, 'Gigabyte B760 DS3H',             4, 120.00),

        -- GPU
        (14, 5, 'NVIDIA GeForce RTX 3060',        2, 320.00),
        (15, 5, 'AMD Radeon RX 6600',             2, 260.00),

        -- Cooling
        (16, 6, 'Cooler Master Hyper 212',        10,  35.00),
        (17, 6, 'Noctua NH-D15',                  5,  90.00),
        (18, 6, 'Arctic Freezer 34 eSports',      8,  40.00),

        -- PSU
        (19, 7, 'Corsair CV550 550W Bronze',       6,  60.00),
        (20, 7, 'Seasonic Focus GX-650 Gold',      4, 105.00),

        -- Peripherals
        (21, 8, 'Logitech MX Keys Keyboard',       7,  95.00),
        (22, 8, 'Razer DeathAdder V2 Mouse',       9,  55.00),

        -- Cables & Adapters
        (23, 9, 'SATA Data Cable',                20,   5.00),
        (24, 9, 'USB-C to DisplayPort Adapter',   12,  15.00),
        (25, 9, '24-pin ATX Extension Cable',     15,   8.00),

        -- Tools & Consumables
        (26, 10, 'Arctic Silver 5 Thermal Paste',  0,   7.50),
        (27, 10, 'ESD Anti-static Wristband',     18,   4.00),
        (28, 10, 'Precision Screwdriver Set',      6,  20.00),
        (29, 10, 'Compressed Air Duster (400ml)', 10,   9.00),
        (30, 10, 'Isopropyl Alcohol 99% (100ml)',  8,   6.00);

    SET IDENTITY_INSERT Items OFF;
    PRINT 'Seed data inserted into [Items].';
END
GO

-- Service
IF NOT EXISTS (SELECT 1 FROM Service)
BEGIN
    SET IDENTITY_INSERT Service ON;

    INSERT INTO Service (ServiceId, CustomerName, DamageType, EntryDate, ServiceStatus, Phone) VALUES
        (1, 'Alice Johnson',    'PC does not boot — no POST beeps',              '2025-01-10 09:15:00', 'Done',       '+1-202-555-0101'),
        (2, 'Bob Martinez',     'Overheating, thermal paste replacement needed', '2025-01-12 14:30:00', 'Done',       '+1-202-555-0102'),
        (3, 'Carol White',      'HDD clicking noise, data backup required',      '2025-02-03 11:00:00', 'Done',       NULL),
        (4, 'David Lee',        'GPU fan not spinning, artifact on screen',      '2025-02-20 16:45:00', 'Done',       '+1-202-555-0104'),
        (5, 'Emma Davis',       'RAM upgrade from 8GB to 16GB',                 '2025-03-05 10:00:00', 'Done',       '+1-202-555-0105'),
        (6, 'Frank Wilson',     'Power supply failure, unit replacement',        '2025-03-18 13:15:00', 'Done',       NULL),
        (7, 'Grace Kim',        'SSD not detected in BIOS',                     '2025-04-02 09:30:00', 'In Process', '+1-202-555-0107'),
        (8, 'Henry Brown',      'Laptop keyboard keys not responding',           '2025-04-10 14:00:00', 'In Process', '+1-202-555-0108'),
        (9, 'Irene Clark',      'Blue screen of death on startup (BSOD)',        '2025-04-15 11:45:00', 'Waiting',    '+1-202-555-0109'),
        (10,'James Taylor',     'Noisy CPU cooler, bearing replacement',         '2025-04-18 15:00:00', 'Waiting',    NULL);

    SET IDENTITY_INSERT Service OFF;
    PRINT 'Seed data inserted into [Service].';
END
GO

-- ServiceDetail  (only for 'Done' and 'In Process' entries)
IF NOT EXISTS (SELECT 1 FROM ServiceDetail)
BEGIN
    SET IDENTITY_INSERT ServiceDetail ON;

    INSERT INTO ServiceDetail (DetailId, ServiceId, ItemId, Qty, Price, Subtotal) VALUES
        -- Service 1: PC no POST → new RAM + motherboard check
        (1,  1, 5,  1,  32.00,  32.00),   -- Corsair 8GB DDR4
        (2,  1, 28, 1,  20.00,  20.00),   -- Screwdriver Set

        -- Service 2: Thermal paste replacement
        (3,  2, 26, 1,   7.50,   7.50),   -- Arctic Silver 5
        (4,  2, 27, 1,   4.00,   4.00),   -- ESD Wristband
        (5,  2, 29, 1,   9.00,   9.00),   -- Air Duster

        -- Service 3: HDD replacement
        (6,  3, 9,  1,  45.00,  45.00),   -- WD Blue 1TB HDD
        (7,  3, 23, 2,   5.00,  10.00),   -- SATA Cable x2

        -- Service 4: GPU swap
        (8,  4, 15, 1, 260.00, 260.00),   -- RX 6600
        (9,  4, 28, 1,  20.00,  20.00),   -- Screwdriver Set

        -- Service 5: RAM upgrade
        (10, 5, 6,  1,  55.00,  55.00),   -- G.Skill 16GB DDR4

        -- Service 6: PSU replacement
        (11, 6, 19, 1,  60.00,  60.00),   -- Corsair CV550
        (12, 6, 25, 1,   8.00,   8.00),   -- 24-pin Extension

        -- Service 7: SSD troubleshoot (In Process)
        (13, 7, 10, 1,  75.00,  75.00),   -- Kingston NV2 NVMe
        (14, 7, 23, 1,   5.00,   5.00),   -- SATA Cable

        -- Service 8: Keyboard (In Process)
        (15, 8, 21, 1,  95.00,  95.00);   -- Logitech MX Keys

    SET IDENTITY_INSERT ServiceDetail OFF;
    PRINT 'Seed data inserted into [ServiceDetail].';
END
GO

-- TransactionService  (one record per 'Done' service)
IF NOT EXISTS (SELECT 1 FROM TransactionService)
BEGIN
    SET IDENTITY_INSERT TransactionService ON;

    INSERT INTO TransactionService (TransactionId, ServiceId, SubTotal, TransactionDate) VALUES
        (1, 1,  52.00, '2025-01-14 10:00:00'),   -- Alice:  32 + 20
        (2, 2,  20.50, '2025-01-15 15:30:00'),   -- Bob:    7.5 + 4 + 9
        (3, 3,  55.00, '2025-02-06 12:00:00'),   -- Carol:  45 + 10
        (4, 4, 280.00, '2025-02-25 17:00:00'),   -- David:  260 + 20
        (5, 5,  55.00, '2025-03-07 11:00:00'),   -- Emma:   55
        (6, 6,  68.00, '2025-03-20 14:00:00');   -- Frank:  60 + 8

    SET IDENTITY_INSERT TransactionService OFF;
    PRINT 'Seed data inserted into [TransactionService].';
END
GO

-- ── 4. VERIFICATION ──────────────────────────────────────────
PRINT '';
PRINT '=== Row counts after setup ===';
SELECT 'Categories'        AS [Table], COUNT(*) AS [Rows] FROM Categories
UNION ALL
SELECT 'Items',                         COUNT(*) FROM Items
UNION ALL
SELECT 'Service',                       COUNT(*) FROM Service
UNION ALL
SELECT 'ServiceDetail',                 COUNT(*) FROM ServiceDetail
UNION ALL
SELECT 'TransactionService',            COUNT(*) FROM TransactionService;
GO

PRINT '';
PRINT 'Setup complete. TechGearDatabase is ready.';
GO
