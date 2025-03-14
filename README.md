# backend-parameteres-lekerdezesek-egyetem

https://classroom.google.com/c/NzU1OTE3MjcwNjMz/a/NzU4ODQ3NDgyMzc0/details

C# Backend Feladat – REST API létrehozása

1. Feladat: Projekt létrehozása
Hozz létre egy új ASP.NET Core Web API projektet a következő névvel: EventProject.
2. Feladat: Adatmodell és Kontextus létrehozása
Az alábbi CSV fájl adatai alapján generálj adatbázis modellt és kontextus réteget az Entity
Framework Core segítségével.
Számításos feladatok
1. Endpoint: `GET /students/count`
Feladat: Készíts egy végpontot, amely visszaadja az összes diák számát.
2. Endpoint: `GET /courses/{course_id}/students/count`
Feladat: Készíts egy végpontot, amely visszaadja egy adott kurzushoz tartozó diákok számát.
3. Endpoint: `GET /teachers/count`
Feladat: Készíts egy végpontot, amely visszaadja az összes tanár számát.
4. Endpoint: `GET /departments/{department_id}/students/count`
Feladat: Készíts egy végpontot, amely visszaadja egy adott tanszékhez tartozó diákok számát.
Projekciós feladatok
1. Endpoint: `GET /students`
Feladat: Készíts egy végpontot, amely visszaadja az összes diák nevét.
2. Endpoint: `GET /courses`
Feladat: Készíts egy végpontot, amely visszaadja az összes kurzus nevét.
3. Endpoint: `GET /teachers`
Feladat: Készíts egy végpontot, amely visszaadja az összes tanár nevét és email címét.
4. Endpoint: `GET /departments`
Feladat: Készíts egy végpontot, amely visszaadja az összes tanszék nevét a „tanszék” végződés
nélkül.
Szűrések
1. Endpoint: `GET /students?age=20`
Feladat: Készíts egy végpontot, amely visszaadja az összes 20 éves diákot.
2. Endpoint: `GET /courses?teacher_id=5`
Feladat: Készíts egy végpontot, amely visszaadja az összes kurzust, amelyet az 5-ös azonosítójú
tanár tart.
3. Endpoint: `GET /teachers?department_id=3`
Feladat: Készíts egy végpontot, amely visszaadja az összes tanárt, akik a 3-as tanszéken dolgoznak.
4. Endpoint: `GET /students?enrolled=true`
Feladat: Készíts egy végpontot, amely visszaadja az összes aktívan beiratkozott diákot.
Rendezés
1. Endpoint: `GET /students?sort=age`
Feladat: Készíts egy végpontot, amely visszaadja az összes diákot életkor szerint növekvő
sorrendben.
2. Endpoint: `GET /courses?sort=name`
Feladat: Készíts egy végpontot, amely visszaadja az összes kurzust név szerint rendezve.
Vegyes feladatok

1. Endpoint: `GET /students/count?department_id=2`
Feladat: Készíts egy végpontot, amely visszaadja a 2-es tanszékhez tartozó diákok számát.
2. Endpoint: `GET /courses?teacher_id=4&amp;sort=name`
Feladat: Készíts egy végpontot, amely visszaadja a 4-es tanár által tartott kurzusokat név szerint
rendezve.
3. Endpoint: `GET /students?age=22&amp;enrolled=true&amp;sort=name`
Feladat: Készíts egy végpontot, amely visszaadja az összes 22 éves aktívan beiratkozott diákot név
szerint rendezve.
