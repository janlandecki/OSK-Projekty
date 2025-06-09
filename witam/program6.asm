; Demo programu - prezentacja przerwa? i operacji arytmetycznych

MOV AX, 10         ; Za?aduj 10 do AX
ADD AX, 5          ; Dodaj 5 do AX
SUB AX, 3          ; Odejmij 3 od AX

; Wy?wietlenie znaku 'A' na ekranie (INT 10h, AH=0Eh, AL='A')
MOV AH, 0Eh
MOV AL, 'A'
INT 10h

; Pobranie listy sprz?tu (INT 11h, AH=00h)
MOV AH, 00h
INT 11h

; Pobranie ilo?ci pami?ci (INT 12h, AH=00h)
MOV AH, 00h
INT 12h

; Odczyt sektora z dysku (INT 13h, AH=02h)
MOV AH, 02h
INT 13h

; Czekanie 100 ms (INT 15h, AH=86h, CX=0, DX=100)
MOV AH, 86h
MOV CX, 0
MOV DX, 100
INT 15h

; Odczyt znaku z klawiatury (INT 16h, AH=10h)
MOV AH, 10h
INT 16h

; Wydruk znaku 'P' (INT 17h, AH=00h, AL='P')
MOV AH, 00h
MOV AL, 'P'
INT 17h

; Uruchomienie bootloadera (INT 19h, AH=00h)
MOV AH, 00h
INT 19h

; Odczyt czasu z RTC (INT 1Ah, AH=02h)
MOV AH, 02h
INT 1Ah

; Wy?wietlenie napisu (INT 21h, AH=09h)
MOV AH, 09h
INT 21h
