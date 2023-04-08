# x64AIT
🧛‍♂️ x64 ASM Instructions Translator

## Before
```ASM
00007FF8D4A0CEA5 | EB 00                    | jmp ntdll.7FF8D4A0CEA7                                        |
00007FF8D4A0CEA7 | 48:83C4 38               | add rsp,38                                                    |
00007FF8D4A0CEAB | C3                       | ret                                                           |
```

## After
```ASM
00007FF8D4A0CEA5 | EB 00                    | jmp ntdll.7FF8D4A0CEA7                                        | // Jump to label/specified location
00007FF8D4A0CEA7 | 48:83C4 38               | add rsp,38                                                    | // Add rsp to 38
00007FF8D4A0CEAB | C3                       | ret                                                           | // Pop return address from stack and jump there
```