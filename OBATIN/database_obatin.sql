CREATE DATABASE IF NOT EXISTS obatin;
USE obatin;

CREATE TABLE IF NOT EXISTS users (
  id_user INT AUTO_INCREMENT PRIMARY KEY,
  username VARCHAR(50) NOT NULL,
  password VARCHAR(50) NOT NULL,
  role VARCHAR(20) NOT NULL
);

CREATE TABLE IF NOT EXISTS obat (
  id_obat INT AUTO_INCREMENT PRIMARY KEY,
  nama_obat VARCHAR(100) NOT NULL,
  harga DECIMAL(12,2) NOT NULL,
  stok INT NOT NULL
);

CREATE TABLE IF NOT EXISTS penjualan (
  id_penjualan INT AUTO_INCREMENT PRIMARY KEY,
  no_nota VARCHAR(30) NOT NULL,
  tanggal DATETIME NOT NULL,
  kasir VARCHAR(50) NOT NULL,
  total_bayar DECIMAL(12,2) NOT NULL
);

CREATE TABLE IF NOT EXISTS detail_penjualan (
  id_detail INT AUTO_INCREMENT PRIMARY KEY,
  id_penjualan INT NOT NULL,
  id_obat INT NOT NULL,
  nama_obat VARCHAR(100) NOT NULL,
  harga DECIMAL(12,2) NOT NULL,
  jumlah INT NOT NULL,
  subtotal DECIMAL(12,2) NOT NULL
);

INSERT INTO users (username, password, role)
SELECT 'admin', 'admin', 'admin'
WHERE NOT EXISTS (
  SELECT 1 FROM users WHERE username = 'admin'
);

INSERT INTO obat (nama_obat, harga, stok)
SELECT 'Paracetamol', 5000, 50
WHERE NOT EXISTS (
  SELECT 1 FROM obat WHERE nama_obat = 'Paracetamol'
);

INSERT INTO obat (nama_obat, harga, stok)
SELECT 'Amoxicillin', 12000, 30
WHERE NOT EXISTS (
  SELECT 1 FROM obat WHERE nama_obat = 'Amoxicillin'
);

INSERT INTO obat (nama_obat, harga, stok)
SELECT 'Vitamin C', 8000, 40
WHERE NOT EXISTS (
  SELECT 1 FROM obat WHERE nama_obat = 'Vitamin C'
);
