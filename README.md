# x64AIT
🧛‍♂️ x64 ASM Instructions Translator

## Table of contents

1. [Explanations](#1-explanations)
2. [State of the project](#2-state-of-the-project)
    1. [Implemented](#1-implemented)
    2. [Comming](#2-comming)
3. [Usage](#3-usage)

## 1. Explanations

<p align="center">
    Welcome on x64AIT
    The goal of this project is to help people to reverse & debug binaries
</p>

## 2. State of the project

<p align="center">
    Currently the project is an external tool where user drags and drop the assembly
    file to x64AIT
    It produces a .ait file where the translation is saved
</p>

### 1. Implemented

- [x] Comment all the lines to explain it
- [x] Build an output file to explain line by line what does the line do

### 2. Comming

- [ ] Find the correct source & destination of the instruction
- [ ] Add registers information
- [ ] Rewrite the ASM instruction as a C code

## 3. Usage

- Drag and drop the ASM file to the binary `x64AIT.exe`
- The translated file will be the path of the file ending with `.ait`

### Example
### Source
```ASM
00007FF8D4A0CEA5 | EB 00                    | jmp ntdll.7FF8D4A0CEA7                                        |
00007FF8D4A0CEA7 | 48:83C4 38               | add rsp,38                                                    |
00007FF8D4A0CEAB | C3                       | ret                                                           |
00007FF8D4A0CEAC | CC                       | int3                                                          |
00007FF8D4A0CEAD | CC                       | int3                                                          |
00007FF8D4A0CEAE | CC                       | int3                                                          |
00007FF8D4A0CEAF | CC                       | int3                                                          |
00007FF8D4A0CEB0 | CC                       | int3                                                          |
00007FF8D4A0CEB1 | CC                       | int3                                                          |
00007FF8D4A0CEB2 | CC                       | int3                                                          |
00007FF8D4A0CEB3 | CC                       | int3                                                          |
00007FF8D4A0CEB4 | 48:895C24 10             | mov qword ptr ss:[rsp+10],rbx                                 |
00007FF8D4A0CEB9 | 48:897424 18             | mov qword ptr ss:[rsp+18],rsi                                 | [rsp+18]:"LdrpInitializeProcess"
00007FF8D4A0CEBE | 55                       | push rbp                                                      |
00007FF8D4A0CEBF | 57                       | push rdi                                                      | rdi:"minkernel\\ntdll\\ldrinit.c"
00007FF8D4A0CEC0 | 41:56                    | push r14                                                      |
00007FF8D4A0CEC2 | 48:8DAC24 00FFFFFF       | lea rbp,qword ptr ss:[rsp-100]                                |
00007FF8D4A0CECA | 48:81EC 00020000         | sub rsp,200                                                   |
00007FF8D4A0CED1 | 48:8B05 48F60B00         | mov rax,qword ptr ds:[7FF8D4ACC520]                           |
00007FF8D4A0CED8 | 48:33C4                  | xor rax,rsp                                                   |
00007FF8D4A0CEDB | 48:8985 F0000000         | mov qword ptr ss:[rbp+F0],rax                                 |
00007FF8D4A0CEE2 | 4C:8B05 27C30B00         | mov r8,qword ptr ds:[7FF8D4AC9210]                            |
00007FF8D4A0CEE9 | 48:8D05 E0AF0500         | lea rax,qword ptr ds:[7FF8D4A67ED0]                           | 00007FF8D4A67ED0:L"apphelp.dll"
00007FF8D4A0CEF0 | 33FF                     | xor edi,edi                                                   |
00007FF8D4A0CEF2 | 48:894424 50             | mov qword ptr ss:[rsp+50],rax                                 |
00007FF8D4A0CEF7 | C74424 48 16001800       | mov dword ptr ss:[rsp+48],180016                              |
00007FF8D4A0CEFF | 48:8D4424 70             | lea rax,qword ptr ss:[rsp+70]                                 | [rsp+70]:L"ÂÄ"
00007FF8D4A0CF04 | 48:894424 68             | mov qword ptr ss:[rsp+68],rax                                 |
00007FF8D4A0CF09 | 48:8BF1                  | mov rsi,rcx                                                   | rcx:sub_7FF8D49CF0E0+14
00007FF8D4A0CF0C | C74424 60 00000001       | mov dword ptr ss:[rsp+60],1000000                             |
00007FF8D4A0CF14 | 41:BE 00010000           | mov r14d,100                                                  |
00007FF8D4A0CF1A | 66:897C24 70             | mov word ptr ss:[rsp+70],di                                   |
00007FF8D4A0CF1F | 4D:85C0                  | test r8,r8                                                    |
00007FF8D4A0CF22 | 74 2B                    | je ntdll.7FF8D4A0CF4F                                         |
00007FF8D4A0CF24 | 8B1425 3003FE7F          | mov edx,dword ptr ds:[7FFE0330]                               |
00007FF8D4A0CF2B | 8D4F 40                  | lea ecx,qword ptr ds:[rdi+40]                                 |
00007FF8D4A0CF2E | 8BC2                     | mov eax,edx                                                   |
00007FF8D4A0CF30 | 83E0 3F                  | and eax,3F                                                    |
00007FF8D4A0CF33 | 2BC8                     | sub ecx,eax                                                   |
00007FF8D4A0CF35 | 8BC2                     | mov eax,edx                                                   |
00007FF8D4A0CF37 | 49:D3C8                  | ror r8,cl                                                     |
00007FF8D4A0CF3A | 4C:33C0                  | xor r8,rax                                                    |
00007FF8D4A0CF3D | B8 010000C0              | mov eax,C0000001                                              |
00007FF8D4A0CF42 | 4C:8906                  | mov qword ptr ds:[rsi],r8                                     |
00007FF8D4A0CF45 | 0F44F8                   | cmove edi,eax                                                 |
00007FF8D4A0CF48 | 8BDF                     | mov ebx,edi                                                   |
00007FF8D4A0CF4A | E9 28010000              | jmp ntdll.7FF8D4A0D077                                        |
00007FF8D4A0CF4F | 48:8D5424 48             | lea rdx,qword ptr ss:[rsp+48]                                 |
00007FF8D4A0CF54 | 48:8D4C24 60             | lea rcx,qword ptr ss:[rsp+60]                                 | rcx:sub_7FF8D49CF0E0+14
00007FF8D4A0CF59 | E8 86C3F9FF              | call <ntdll.sub_7FF8D49A92E4>                                 |
00007FF8D4A0CF5E | 8BD8                     | mov ebx,eax                                                   |
00007FF8D4A0CF60 | 85C0                     | test eax,eax                                                  |
00007FF8D4A0CF62 | 0F88 FB000000            | js ntdll.7FF8D4A0D063                                         |
00007FF8D4A0CF68 | 4C:8D45 70               | lea r8,qword ptr ss:[rbp+70]                                  |
00007FF8D4A0CF6C | BA 01400000              | mov edx,4001                                                  |
00007FF8D4A0CF71 | 33C9                     | xor ecx,ecx                                                   |
00007FF8D4A0CF73 | E8 6CDBF4FF              | call ntdll.7FF8D495AAE4                                       |
00007FF8D4A0CF78 | 4C:8D4C24 40             | lea r9,qword ptr ss:[rsp+40]                                  | [rsp+40]:L"KnownDllPath"
00007FF8D4A0CF7D | 45:33C0                  | xor r8d,r8d                                                   |
00007FF8D4A0CF80 | 48:8D55 70               | lea rdx,qword ptr ss:[rbp+70]                                 |
00007FF8D4A0CF84 | 48:8D4C24 60             | lea rcx,qword ptr ss:[rsp+60]                                 | rcx:sub_7FF8D49CF0E0+14
00007FF8D4A0CF89 | E8 5EBCF3FF              | call <ntdll.sub_7FF8D4948BEC>                                 |
00007FF8D4A0CF8E | 8BD8                     | mov ebx,eax                                                   |
```

### Report
```
line:8: Push rbp empty onto stack
line:9: Push rbx empty onto stack
line:10: Push rsi empty onto stack
line:11: Push rdi empty onto stack
line:12: Push r12 empty onto stack
line:13: Push r14 empty onto stack
line:14: Push r15 empty onto stack
line:15: Load effective address of rbp into empty
line:16: Subtract rsp from empty
line:17: Move rax to empty
line:18: Bitwise XOR rax by rsp
line:19: Move rax to empty
line:21: Move eax to empty
line:22: Move edi to r9d
line:23: Move rsi to r8
line:24: Move r14 to rcx
line:25: Set condition codes according to bx - ax
line:26: Jump if above or equal (unsigned) empty empty
line:27: Move rdx to empty
line:28: Load effective address of r8 into empty
line:30: Push return address and jump to label / specified location empty empty
line:31: Bitwise XOR r15d by r15d
line:32: Set condition codes according to eax & eax
line:34: Move r15w to empty
line:35: Set condition codes according to edi & edi
line:36: Jump if not equal / nonzero empty empty
line:37: Load effective address of rax into empty
line:38: Move bx to empty
line:39: Move rax to empty
line:40: Load effective address of rdx into empty
line:41: Load effective address of rax into empty
line:42: Move bx to empty
line:43: Bitwise XOR r8d by r8d
line:44: Move rax to empty
line:45: Load effective address of rcx into empty
line:46: Move empty to empty
line:47: Push return address and jump to label / specified location empty empty
line:48: Set condition codes according to eax & eax
line:51: Move rdx to empty
line:52: Add rcx to rdx
line:53: Jump to label / specified location empty empty
line:54: Move rax to rcx
line:55: Decrement rcx empty by 1
line:56: Set condition codes according to empty - empty
line:57: Jump if equal / zero empty empty
line:58: Set condition codes according to rcx - rdx
line:59: Jump if above (unsigned) empty empty
line:60: Jump to label / specified location empty empty
line:61: Move rcx to rax
line:62: Subtract cx from empty
line:63: Move cx to empty
line:64: Bitwise XOR eax by eax
line:65: Move rcx to empty
line:66: Bitwise XOR rcx by rsp
line:67: Push return address and jump to label / specified location empty empty
line:68: Add rsp to empty
line:69: Pop top of stack into r15 empty
line:70: Pop top of stack into r14 empty
line:71: Pop top of stack into r12 empty
line:72: Pop top of stack into rdi empty
line:73: Pop top of stack into rsi empty
line:74: Pop top of stack into rbx empty
line:75: Pop top of stack into rbp empty
line:76: Pop return address from stack and jump there empty empty
line:85: Pop top of stack into rdi empty
line:89: Move esi to empty
line:90: Add al to empty
line:91: Jump to label / specified location empty empty
```