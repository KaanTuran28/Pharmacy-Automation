# Pharmacy Automation

![C#](https://img.shields.io/badge/C%23-WinForms-178600)
![.NET](https://img.shields.io/badge/.NET_Framework-4.7.2-512bd4)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927)
![License](https://img.shields.io/badge/license-MIT-green)

<p align="center"><b><a href="#english">English</a></b> · <b><a href="#türkçe">Türkçe</a></b></p>

---

## English

A desktop pharmacy management system built in C# (Windows Forms) with a SQL Server backend, for managing inventory, sales and users. The repository also contains a small static "pharmacy info" website.

### Features

- **Login with two roles:** Administrator and Pharmacist.
- **Administrator:** add, view and manage users; edit own profile.
- **Pharmacist:** add, update and list medicines, check expiry dates and record sales.
- **Printing / PDF:** data-grid printing (DGVPrinter) and PDF/barcode generation with iText 8.

### Tech stack

- C# / Windows Forms, .NET Framework 4.7.2
- SQL Server (`pharmacy` database), accessed with ADO.NET (`SqlConnection`)
- iText 8 (PDF, barcodes) + BouncyCastle
- Opened and built with Visual Studio (`PharmacyManagementSystem.sln`)

### Setup

1. Open `PharmacyManagementSystem/PharmacyManagementSystem.sln` in Visual Studio.
2. Restore the NuGet packages (`packages.config`).
3. Create a SQL Server database named `pharmacy` with the tables the app expects (users, medicines, sales).
4. Update the connection string in `function.cs` (it currently points to a local `Data Source=YOUR_SERVER` with integrated security).
5. Build and run.

### Static website

The `Eczane web site/` folder is a separate, static informational site about medicine categories (pain relief, allergy, antibiotics, digestion, vitamins). Open `index.html` in a browser.

### Structure

```
├── PharmacyManagementSystem/        # C# WinForms solution
│   └── PharmacyManagementSystem/
│       ├── FrmLogin / FrmAdminstrator / FrmPharmacist   # Forms
│       ├── AdministratorUC/          # Admin user controls
│       ├── PharmacistUC/             # Pharmacist user controls
│       ├── function.cs               # DB access layer
│       └── DGVPrinter.cs             # Grid printing helper
└── Eczane web site/                  # Static informational site
```

> **Note:** This is an early project. The database connection is hard-coded and login uses string-concatenated SQL; before any real use the connection string should be externalised and the queries parameterised. Visual Studio build artifacts (`.vs/`, `bin/`, `obj/`) were committed and could be removed with a `.gitignore`.

### License

MIT — see [LICENSE](./LICENSE).

---

## Türkçe

C# (Windows Forms) ile yazılmış, SQL Server arka uçlu bir masaüstü eczane yönetim sistemi; stok, satış ve kullanıcı yönetimi yapar. Depoda ayrıca küçük, statik bir "eczane bilgi" sitesi de var.

### Özellikler

- **İki rollü giriş:** Yönetici (Administrator) ve Eczacı (Pharmacist).
- **Yönetici:** kullanıcı ekleme, görüntüleme ve yönetme; kendi profilini düzenleme.
- **Eczacı:** ilaç ekleme, güncelleme ve listeleme, son kullanma tarihi kontrolü ve satış kaydı.
- **Yazdırma / PDF:** veri tablosu yazdırma (DGVPrinter) ve iText 8 ile PDF/barkod üretimi.

### Kullanılan teknolojiler

- C# / Windows Forms, .NET Framework 4.7.2
- SQL Server (`pharmacy` veritabanı), ADO.NET (`SqlConnection`) ile erişim
- iText 8 (PDF, barkod) + BouncyCastle
- Visual Studio ile açılıp derlenir (`PharmacyManagementSystem.sln`)

### Kurulum

1. `PharmacyManagementSystem/PharmacyManagementSystem.sln` dosyasını Visual Studio'da açın.
2. NuGet paketlerini geri yükleyin (`packages.config`).
3. `pharmacy` adında, uygulamanın beklediği tabloları (kullanıcılar, ilaçlar, satışlar) içeren bir SQL Server veritabanı oluşturun.
4. `function.cs` içindeki bağlantı dizesini güncelleyin (şu an yerel `Data Source=YOUR_SERVER` ve entegre güvenliğe işaret ediyor).
5. Derleyip çalıştırın.

### Statik web sitesi

`Eczane web site/` klasörü, ilaç kategorileri (ağrı kesici, alerji, antibiyotik, sindirim, vitaminler) hakkında bilgi veren ayrı, statik bir sitedir. `index.html` dosyasını tarayıcıda açın.

### Yapı

```
├── PharmacyManagementSystem/        # C# WinForms çözümü
│   └── PharmacyManagementSystem/
│       ├── FrmLogin / FrmAdminstrator / FrmPharmacist   # Formlar
│       ├── AdministratorUC/          # Yönetici kullanıcı kontrolleri
│       ├── PharmacistUC/             # Eczacı kullanıcı kontrolleri
│       ├── function.cs               # Veritabanı erişim katmanı
│       └── DGVPrinter.cs             # Tablo yazdırma yardımcısı
└── Eczane web site/                  # Statik bilgi sitesi
```

> **Not:** Bu erken dönem bir projedir. Veritabanı bağlantısı koda gömülü ve giriş, string birleştirmeli SQL kullanıyor; gerçek bir kullanımdan önce bağlantı dizesi dışarı alınmalı ve sorgular parametreli hale getirilmelidir. Visual Studio derleme artıkları (`.vs/`, `bin/`, `obj/`) commit edilmiş; bir `.gitignore` ile temizlenebilir.

### Lisans

MIT — bkz. [LICENSE](./LICENSE).
