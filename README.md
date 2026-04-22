# Forslag til svar på Eksempel på eksamen. (PDF ligger med)
### Noen av spørsmålene kan du og finne i _"Program.cs"_ for å teste ut kode og se at det virker. 

---

## Del 1 - Flervalgsspørsmål:
### 1. En klasse er:
- En mal for å beskrive en spesifikk kode logikk
- En kodeblokk som returnerer en verdi
- **En mal for å opprette objekter**
- En liste med variabler

### 2. Et objekt er:
- En datatype som bare brukes i arrays
- **En instans av en klasse**
- En konstrøktør
- En kommentar i koden

### 3. En konstruktør brukes til:
-  Å skrive tekst til konsollen
-  Å arve fra en annen klasse
-  Å slette objekter
-  **Å initialisere et objekt når det opprettes**


### 4. Hva er resultatet?
```csharp
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(i);
}
```
- 1 2 3
- **0 1 2**
- 0 1 2 3
- Uendelig løkke

### 5. Hva er resultatet?
```csharp
int x = 5;
Console.WriteLine(x++);
Console.WriteLine(x);
```
- 5 og 5
- 6 og 6
- **5 og 6**
- 6 og 5

### 6. Hva skjer i denne koden?
```csharp
int[] numbers = { 1, 2, 3 };
Console.WriteLine(numbers[3]);
```
- Skriver 3
- Skriver 0
- **IndexOutOfRangeException**
- NullReferenceException

### 7. Hva betyr private?
- Tilgjengelig overalt
- **Tilgjengelig kun i samme klasse**
- Tilgjengelig kun i subklasser
- Tilgjengelig kun i Main


### 8. Hva er forskjellen mellom `Array` og `List<T>`?
-  Ingen forskjell
-  Array har dynamisk størrelse
-  **List<T> kan vokse og krympe****
-  List<T> kan ikke lagre objekter

### 9. Hvilket nøkkelord brukes i basisklassen for at en metode skal kunne overstyres?
-  override
-  **virtual**
-  abstract
-  static

### 10. Hva brukes try-catch til?
-  Å opprette objekter
-  **Å håndtere feil / unntak**
-  Å arve klasser
-  Å lage tester

### 11. Hva er en enhetstest?
-  En test av hele systemet
-  **En test av én liten isolert del av programmet**
-  En test som alltid bruker database
-  En test som bare kjøres manuelt

### 12. Hva er riktig om gode enhetstester?
-  Avhengige av mange andre klasser
-  **Isolerte og repeterbare**
-  Skriver alltid til konsollen
-  Tester alt i én testmetode

### 13. Hvilken kode oppretter et objekt av klassen `Car`?
-  Car = new Car;
-  Car myCar = Car();
-  **Car myCar = new Car();**
-  new myCar = Car();

### 14. Polymorfisme er:
-  At en klasse bare kan ha én metode
-  **At samme metodegrensesnitt kan gi ulik oppførsel**
-  At alle objekter må ha samme type
-  At variabler ikke kan endres

### 15. Hva er forskjellen på overloading og overriding?
-  Ingen forskjell
-  **Overloading: ulik parameterliste, overriding: ny implementasjon i subklasse**
-  Overloading brukes bare i interface
-  Overriding brukes bare i lister

### 16. En abstrakt klasse er:
-  En klasse som alltid kan instansieres
-  En klasse uten egenskaper
-  **En klasse som ikke kan opprettes direkte som objekt**
-  En klasse som bare inneholder static metoder

### 17. Hva tester denne enhetstesten best?

```csharp
[Fact]
public void Add_TwoNumbers_ReturnsCorrectSum()
{
    Calculator c = new Calculator();
    int result = Add(2, 3);
    Assert.Equal(5, result);
}
```

-  At konstruktøren kaster exception
-  **At Add(2, 3) returnerer 5**
-  At hele systemet virker
-  At input leses fra tastatur

### 18. Hva er hovedideen med private felt og public properties?
-  Å gjøre koden kortere uten grunn
-  **Å støtte innkapsling**
-  Å erstatte konstruktører
-  Å unngå klasser

### 19. Hva gjør denne konstruktøren?

```csharp
public Student(string name)
{
    Name = name;
}
```

-  Oppretter en metode som returnerer string
-  **Initialiserer objektets tilstand**
-  Sletter objektet
-  Arver fra en annen klasse

### 20. Hva skjer i denne koden?

```csharp
string text = null;
Console.WriteLine(text.Length);
```

-  Skriver 0
-  **NullReferenceException**
-  IndexOutOfRangeException
-  Kompileringsfeil

---