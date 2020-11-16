﻿# Freshfruit
Aplikasi yang bisa menyesuaikan 

## Scope & Functionalities
- Dapat menambahkan Buah ke keranjang sesuai kapasitas
- Dapat meghapus buah yang sudah di masukan
- Terdapat peringatan jika keranjang sudah penuh

## Tugas

### Fungsi dari BucketEventListener
Jika buah yang dimasukkan ke dalam keranjang yang belum penuh maka akan ada pesan "berhasil ditambahkan" , 
Tapi jika buah yang dimasukan ke keranjang yang sudah Penuh maka akn muncul pesan "keranjang penuh"

### Class Diagram
![Class Diagram]()

### Alur dan Logika pemrogramannya
Terdapat 6 class yaitu `Fruit.cs`, `Bucket.cs`,`BucketController.cs`, `BucketListener.cs`, `Seller.cs`, dan `BucketEvenListener.cs` yang mengatur jalannya aplikasi ini . `Fruit.cs` digunakan untuk menampung dari jenis-jenis buah, kemudian pada `Seller.cs` digunakan untuk mengatur sellernya dia akan menambah ataupun menghapus buah dari keranjang, dia mengambil dari class `BucketController.cs` kemudian `Bucket.cs` yang mengatur banyaknya kapasitas dan menjadikan list buah yang ditambahkan kemudain `BucketEvenListener.cs` digunakan untuk memberi peringatan apakah berhasil menambahkan atau tidak dan peringatan itu diambil dari class `BucketListener.cs`