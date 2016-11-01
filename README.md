# Star Trek #
A reworking of the 1971 Star Trek text game using C#

Based on:  
http://www.codeproject.com/Articles/28228/Star-Trek-1971-Text-Game

## Source Code ##

The full source code is available here from GitHub:

 - Clone the source: `git clone https://github.com/timdetering/BaconBytes.StarTrek`
 - Initialize the submodules: `git submodule update --init`
 - **TODO** Run `Protobuild.exe` to generate project files and solutions.

## Projects ##
 - **StarTrekClassic:** Original BASIC code ported straight to C# (including line numbers).
 - **StarTrek1971:** Cleaned-up port, still resembles the original BASIC version.
 - **StarTrek1971.Net:** Console C# version of the classic 1971 Star Trek.
 - **SuperStarTrek:** TODO


## A Bit of History ##
Two years after the original series was canceled in 1969, high school senior Mike Mayfield was busy keeping the *Star Trek* universe alive by feeding punched paper tape into a Sigma 7 in an effort to bring the crew of the Enterprise and the Klingon Empire to life on a 10 character-per-second teletype terminal. Soon after Mike ported his game to HP BASIC, it entered the public domain. From there, early computer enthusiasts enhanced and rewrote the game for every flavor of mini and microcomputer BASIC imaginable and beyond.

I remember encountering versions of the game back in the early 80's when I was a little kid trying to learn BASIC on my IBM PCjr. Back then, computer books and magazines distributed programs in printed form. Meaning, you had to type them in to play the games. It was a pain in the ass, but the process encouraged you to tinker. It motivated you to learn to code and to tweak or even improve the programs you were entering in.

Every BASIC game book that I picked up contained some version of the Star Trek game. I recall loading it up a few times, but each time I ended up staring at the screen in utter confusion. "How the heck is this Star Trek?" I remember thinking. I couldn't figure out how to play it.

By the time I entered high school, I had graduated from BASIC and moved onto to bigger and better things like C and C++. But, on occasion, I often wondered about the Star Trek text game. What made it so popular? After learning about the history that I touched upon above, I decided to dig it up and take a second look.

After a bit of web surfing, I came across Mike Mayfield's original port to HP BASIC. Here's a snippet of the code:

```
100  REM *****************************************************************
110  REM ***                                                           ***
120  REM *** STAR TREK: BY MIKE MAYFIELD, CENTERLINE ENGINEERING       ***
130  REM ***                                                           ***
140  REM ***TOTAL INTERACTION GAME - ORIG. 20 OCT 1972
150  REM ***                                                           ***
160  REM *****************************************************************
170  GOSUB 5460
180  PRINT "  STAR TREK "
190  PRINT "DO YOU WANT INSTRUCTIONS (THEY'RE LONG!)";
200  INPUT A$
210  IF A$ <> "YES" THEN 230
220  GOSUB 5820
230  REM *****  PROGRAM STARTS HERE *****
```

Ah, good old line-numbered BASIC. It's all coming back to me now. Those line numbers were there to provide targets for `GOTO` and `GOSUB` statements. But, line numbers made editing a tad difficult. It was convention to enter in line numbers that were multiples of 10. That way, as you developed the program, you could go back and insert up to 9 additional statements in between existing lines without reworking all the `GOTO`/`GOSUB` references. If you needed to insert more than 9 lines, I remember a special feature in the BASIC editor on my PCjr. It would append a zero to all line numbers and all line number references throughout the program. Meaning, you could now insert up to 99 lines. Couldn't they just renumber the program in multiples of 10? Nah. The PCjr wasn't powerful enough for that.

If you're wondering about *"Centerline Engineering"* it was an imaginary company that Mike Mayfield coined to give his BASIC projects a level of prominence to those reading the remarks section.

With code in hand, I really wanted to play the game. I'm sure that there are HP BASIC interpreters out there for modern machines, but what fun would that be. Before I played it, I wanted do my own port. This game was born in the hobbyist era. It was made to be reinterpreted and enhanced as it traded handed. I wanted to bring back part of those long-lost magical days of type-in programs.

My first impression of the code was "what's with all the single letter variable names?" First I thought it was a limitation of HP BASIC, but then I noticed the occasional 2-letter names. I guess 2 is better than 1. Everything is also in caps. Take a look at this line:

```
2140  T=T+1
```

That line increments T. But, due to the caps, I feel like the code is screaming at me. ASSIGN THE SUM OF T AND 1 BACK TO T DAMN IT! Also, I'm so used to writing t++ or t += x that I forgot about the expanded notation. In fact, entering 7th grade having mastered BASIC, I found myself really confused when my math teacher introduced us to solving simultaneous equations. For instance, find the value of X in this equation:

```
X = 2X - 6
```

That was the first time I was introduced to the concept of operator overloading. The equals-sign can mean variable assignment or numerical equivalence depending on the context.

Here's a cool block of code that I noticed:

```
4550  IMAGE  8(X,3A)
4560  IMAGE  8(X,3A),8X,"STARDATE",8X,5D
4570  IMAGE  8(X,3A),8X,"CONDITION",8X,6A
4580  IMAGE  8(X,3A),8X,"QUADRANT",9X,D,",",D
4590  IMAGE  8(X,3A),8X,"SECTOR",11X,D,",",D
4600  IMAGE  8(X,3A),8X,"ENERGY",9X,6D
4610  IMAGE  8(X,3A),8X,"PHOTON TORPEDOES",3D
4620  IMAGE  8(X,3A),8X,"SHIELDS",8X,6D
```

These are not executable statements. They're strings that can be referenced in PRINT commands. The unquoted symbols get substituted with values of variables. It's conceptually similar to C-style `printf()` format placeholders. I didn't realize that BASIC offered such a rich numerical formatting notation.

As I continued to examine the source, I found some statements that didn't make sense. For instance, even though you don't have to declare variables before you use them, you still need to specify the dimensions of arrays. I came across some arrays that were never allocated as such. Ultimately, I decided to seek out a better basis for my port.

After a bit of Googling, I found a cleaned up version that maintained the majority of Mike Mayfield's code. Some of it was reworked, probably to enable it to run on modern versions of BASIC. For instance, those cool IMAGE statements were dropped and replaced with sets of simpler `PRINT` commands. The variable names appear virtually identical, but at least they are all accounted for in this version.

## Porting the Game ##
Next, I had to decide what language to port it to. Staring at that BASIC code reminded me that C# brought goto back into the mainstream. Would it be possible to do an exact line-by-line port from BASIC to C#? Apparently so... and the result is some of the sickest code I've ever keyed into a computer. Want a comparison? Here's a segment of BASIC code:

```
2950  PRINT "TORPEDO TRACK:"
2960  LET X=X+X[1]
2970  LET Y=Y+X[2]
2980  IF X<.5 OR X >= 8.5 OR Y<.5 OR Y >= 8.5 THEN 3420
2990  LET V[4]=X
2991  LET V[5]=Y
2992  GOSUB 9000
2993  PRINT
3020  IF A[INT(X+.5),INT(Y+.5)]#0 THEN 3080
3060  GOTO 2960
3080  IF A[INT(X+.5),INT(Y+.5)]#2 THEN 3230
3120  PRINT "*** KLINGON DESTROYED ***"
3130  LET P[1]=P[1]-1
3140  LET P[3]=P[3]-1
3150  IF P[3] <= 0 THEN 4040
3160  FOR I=1 TO 3
3170  IF INT(X+.5)#K[I,1] THEN 3190
3180  IF INT(Y+.5)=K[I,2] THEN 3200
3190  NEXT I
3200  LET K[I,3]=0
3210  GOTO 3370
3230  IF A[INT(X+.5),INT(Y+.5)]#4 THEN 3290
3270  PRINT "YOU CAN'T DESTROY STARS SILLY"
3280  GOTO 3420
```

And the C# version:

```
_2950: Console.WriteLine("TORPEDO TRACK:");
_2960: X = X + _X[1];
_2970: Y = Y + _X[2];
_2980: if (X < .5 || X >= 8.5 || Y < .5 || Y >= 8.5) goto _3420;
_2990: _V[4] = X;
_2991: _V[5] = Y;
_2992: _9000();
_2993: Console.WriteLine();
_3020: if (_A[(int)(X + .5), (int)(Y + .5)] != 0) goto _3080;
_3060: goto _2960;
_3080: if (_A[(int)(X + .5), (int)(Y + .5)] != 2) goto _3230;
_3120: Console.WriteLine("*** KLINGON DESTROYED ***");
_3130: _P[1] = _P[1] - 1;
_3140: _P[3] = _P[3] - 1;
_3150: if (_P[3] <= 0) goto _4040;
_3160: for(I = 1; I <= 3; I += 1) {
_3170:   if ((int)(X + .5) != _K[(int)I, 1]) goto _3190;
_3180:   if ((int)(Y + .5) == _K[(int)I, 2]) goto _3200;
_3190: ;} I = 3;
_3200: _K[(int)I, 3] = 0;
_3210: goto _3370;
_3230: if (_A[(int)(X + .5), (int)(Y + .5)] != 4) goto _3290;
_3270: Console.WriteLine("YOU CAN'T DESTROY STARS SILLY");
_3280: goto _3420;
```

To simulate line numbers, each line starts with a label consisting of an underscore followed by a number. That works fine for `GOTO`, but what about `GOSUB`? Examine line 2992. Subroutines were replaced with methods. That almost worked. In BASIC, you're not forced to `RETURN` from subroutines. You can leave them via `GOTO`. That was used only in the case that the player is destroyed to send them back to the beginning of the program to start over. I replaced that `GOTO` with a return statement that passes a flag back to the caller. The caller inspects the flag and jumps back to the program start if need be. I also discovered that at one point, there is a `GOTO` that jumps into a FOR loop. C# won't let you jump to a label in a sub-block of code. I transformed the FOR loop into a `GOTO` loop to make C# happy.

All the variables in the BASIC program, including the arrays, are real number type. However, in BASIC, an array and a scalar can share the same name; the interpreter is able to sort it all out. But, C# is less kind. To solve the problem, I prefixed array names with underscores. Also, arrays in BASIC are indexed from `1` instead of `0`. To compensate, I increased the length of all arrays by 1. Index `0` is never used.

When I started testing my port, I noticed some string formatting problems. Examine the following BASIC line:

```
2726  PRINT TAB(41);"(";
```

That means: print 41 spaces followed by left-parenthesis. That was easy to translate, but the intension was to push the left-parenthesis onto the next line by letting it wrap around the console. I cleaned some of this stuff up. There are also some tables that get printed in the game. I reformatted them a bit to make them easier to read.

One other thing: notice that in this type of BASIC, `#` indicates not-equal-to. It took me a while to realize why they chose that symbol, `#` resembles `≠`.

## Entering the Star Trek Universe ##
Now, I was ready to play the game. As I mentioned above, I never understood the rules before. Luckily, when you run the program, it gives you the option of viewing instructions. I studied them carefully. But, the only way to really understand what to do is to play the game. Here's a walkthrough:

```
                          STAR TREK



ENTER 1 OR 2 FOR INSTRUCTIONS (ENTER 2 TO PAGE)

ENTER SEED NUMBER
INITIALIZING...

YOU MUST DESTROY 17 KINGONS IN 30 STARDATES WITH 3 STARBASES

-=--=--=--=--=--=--=--=-
    *
                         STARDATE  2100
                *     *  CONDITION GREEN
            <*>          QUADRANT  5,2
    *                    SECTOR    5,4
                         ENERGY    3000
                         SHIELDS   0
                   *     PHOTON TORPEDOES 10
-=--=--=--=--=--=--=--=-
COMMAND
```

The game makes itself known by printing out its title. Then, it asks you if you want to view instructions. Every prompt in the game demands a number. If you hit `Enter`, zero is assumed. In this case, I hit `Enter` to skip the instructions. Next, it asks for a seed number to initialize the randomizer. This is an artifact of BASIC. It doesn't really have an effect in C#. In BASIC, just as in C#, the randomizer could have been initialized based off the system time. If that was not an option, they should have taken advantage of the instructions prompt. When the instructions prompt appears, it could have entered a loop that timed how long it took the user to enter a value. That duration could have been used to initialize the randomizer. Again, I simply pressed `Enter` to skip it.

Next, it prints out my mission. I have to destroy 17 Klingon (note the game misspells it here) ships in 30 units of time with 3 starbases. Then it runs the short range scanner. The short range scanner displays the current quadrant. The game takes place in an 8×8 quadrant grid. Each row and column is numbered 1 to 8. The text on the right indicates that I am in quadrant (5,2). Each quadrant is partitioned into an 8×8 sector grid. The Enterprise is located at sector (5,4). On the quadrant display, `<*>` is the *Enterprise*. The remaining `*`'s are stars. Each `=` mark on the top and bottom horizontal-line dividers indicates a column. If you count, you'll find that the *Enterprise* is in column 5. If you count the rows, you'll find it's in row 4. Hence, within this quadrant, the Enterprise is in sector (5,4) as specified.

The goal is seek out quadrants containing Klingon ships and destroy them. Let's begin by doing a long range sensor scan (option 2):

```
COMMAND 2
LONG RANGE SENSOR SCAN FOR QUADRANT 5,2
-------------------
| 008 | 008 | 004 |
-------------------
| 006 | 005 | 007 |
-------------------
| 001 | 104 | 113 |
-------------------
```

This table summarizes 9 quadrants. The center quadrant is your current quadrant. The digits indicate the number of Klingon ships, the number of starbases and the number of stars. In our quadrant, there are no Klingon ships and no starbases, but there are 5 stars. Stars act as annoying obstacles as I’ll demonstrate later on. South of us, there is a quadrant containing 1 Klingon ship. Let's head there. But, first we need to raise shields (option 5):

```
COMMAND 5
ENERGY AVAILABLE = 3000
NUMBER OF UNITS TO SHIELDS 500
```

It asks me how much energy I want to devote to the shields. I entered `500`. If I run out of energy, I lose the game. Starbases replenish energy. They also restock photon torpedoes and repair damage. To see how much energy I have left, I’ll run a short range scan again (option 1):

```
COMMAND 1
-=--=--=--=--=--=--=--=-
    *
                         STARDATE  2100
                *     *  CONDITION GREEN
            <*>          QUADRANT  5,2
    *                    SECTOR    5,4
                         ENERGY    2500
                         SHIELDS   500
                   *     PHOTON TORPEDOES 10
-=--=--=--=--=--=--=--=-
```

Now, let’s head south. Navigation requires 2 parameters: direction and distance. It’s a polar coordinate system, but an unconventional one. Direction is specified using this:

```
4    3    2
 `.  :  .'
   `.:.'
5---<*>---1
   .':`.
 .'  :  `.
6    7    8
```


## TODO ##
 - [ ] Explore using ProtoBuild to generate cross-platform project files.
 - [ ] Detect console window size and adjust new line/carriage return number and position.
 - [ ] Create empty NUnit test project(s).
   - [ ] Implement play tests.


## References ##
 - **Star Trek Game History:** http://www3.sympatico.ca/maury/games/space/star_trek.html
 - **Wiki:** http://en.wikipedia.org/wiki/Star_Trek_%28text_game%29
 - **Mike Mayfield's Original Code:** http://www.dunnington.u-net.com/public/startrek/STTR1
 - **Enhanced Version:** http://newton.freehostia.com/hp/bas/TREKPT.txt
 - **Super Star Trek:** http://www.atariarchives.org/bcc1/showpage.php?page=275
 - **Kermit Murray's TREK73 page** http://www.kermitmurray.com/trek73/ and http://www.kermitmurray.com/trek73/old-index.html

## License ##
The original article, along with any associated source code and files, is licensed under [The GNU Lesser General Public License (LGPLv3)](http://www.opensource.org/licenses/lgpl-3.0.html).

**TODO** New code is licensed under?