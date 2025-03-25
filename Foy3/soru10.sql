SELECT c.ad, c.soyad, c.maas, b.birim_ad
FROM calisanlar c
JOIN birimler b ON c.calisan_birim_id = b.birim_id
WHERE c.maas = (
    SELECT MAX(maas) 
    FROM calisanlar 
    WHERE calisan_birim_id = c.calisan_birim_id
);
