# x64AIT
🧛‍♂️ x64 ASM Instructions Translator

## Before
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
00007FF8D4A0CF90 | 40:38BD EC000000         | cmp byte ptr ss:[rbp+EC],dil                                  |
00007FF8D4A0CF97 | 74 09                    | je ntdll.7FF8D4A0CFA2                                         |
00007FF8D4A0CF99 | 48:8B4D 70               | mov rcx,qword ptr ss:[rbp+70]                                 | rcx:sub_7FF8D49CF0E0+14
00007FF8D4A0CF9D | E8 3E58F5FF              | call <ntdll.RtlReleasePath>                                   |
00007FF8D4A0CFA2 | 85DB                     | test ebx,ebx                                                  |
00007FF8D4A0CFA4 | 79 3A                    | jns ntdll.7FF8D4A0CFE0                                        |
00007FF8D4A0CFA6 | 48:8D4424 60             | lea rax,qword ptr ss:[rsp+60]                                 |
00007FF8D4A0CFAB | 895C24 30                | mov dword ptr ss:[rsp+30],ebx                                 |
00007FF8D4A0CFAF | 48:894424 28             | mov qword ptr ss:[rsp+28],rax                                 |
00007FF8D4A0CFB4 | 4C:8D05 B5F90600         | lea r8,qword ptr ds:[7FF8D4A7C970]                            | 00007FF8D4A7C970:"LdrpGetProcApphelpCheckModule"
00007FF8D4A0CFBB | 48:8D05 6EF90600         | lea rax,qword ptr ds:[7FF8D4A7C930]                           | 00007FF8D4A7C930:"Loading the shim engine DLL \"%wZ\" failed with status 0x%08lx\n"
00007FF8D4A0CFC2 | 45:33C9                  | xor r9d,r9d                                                   |
00007FF8D4A0CFC5 | BA E70D0000              | mov edx,DE7                                                   |
00007FF8D4A0CFCA | 48:894424 20             | mov qword ptr ss:[rsp+20],rax                                 |
00007FF8D4A0CFCF | 48:8D0D 329C0500         | lea rcx,qword ptr ds:[7FF8D4A66C08]                           | rcx:sub_7FF8D49CF0E0+14, 00007FF8D4A66C08:"minkernel\\ntdll\\ldrinit.c"
00007FF8D4A0CFD6 | E8 D596F4FF              | call ntdll.7FF8D49566B0                                       |
00007FF8D4A0CFDB | E9 83000000              | jmp ntdll.7FF8D4A0D063                                        |
00007FF8D4A0CFE0 | 48:8B4424 40             | mov rax,qword ptr ss:[rsp+40]                                 | [rsp+40]:L"KnownDllPath"
00007FF8D4A0CFE5 | 44:0970 68               | or dword ptr ds:[rax+68],r14d                                 |
00007FF8D4A0CFE9 | 48:8B4424 40             | mov rax,qword ptr ss:[rsp+40]                                 | [rsp+40]:L"KnownDllPath"
00007FF8D4A0CFEE | 48:8B48 30               | mov rcx,qword ptr ds:[rax+30]                                 | rcx:sub_7FF8D49CF0E0+14
00007FF8D4A0CFF2 | 48:890D 6F730A00         | mov qword ptr ds:[7FF8D4AB4368],rcx                           | rcx:sub_7FF8D49CF0E0+14
00007FF8D4A0CFF9 | E8 5AC3F9FF              | call ntdll.7FF8D49A9358                                       |
00007FF8D4A0CFFE | 8BD8                     | mov ebx,eax                                                   |
00007FF8D4A0D000 | 85C0                     | test eax,eax                                                  |
00007FF8D4A0D002 | 79 2D                    | jns ntdll.7FF8D4A0D031                                        |
00007FF8D4A0D004 | 894424 28                | mov dword ptr ss:[rsp+28],eax                                 |
00007FF8D4A0D008 | 4C:8D05 61F90600         | lea r8,qword ptr ds:[7FF8D4A7C970]                            | 00007FF8D4A7C970:"LdrpGetProcApphelpCheckModule"
00007FF8D4A0D00F | 48:8D05 32F80600         | lea rax,qword ptr ds:[7FF8D4A7C848]                           | 00007FF8D4A7C848:"Getting the shim engine exports failed with status 0x%08lx\n"
00007FF8D4A0D016 | 45:33C9                  | xor r9d,r9d                                                   |
00007FF8D4A0D019 | BA F20D0000              | mov edx,DF2                                                   |
00007FF8D4A0D01E | 48:894424 20             | mov qword ptr ss:[rsp+20],rax                                 |
00007FF8D4A0D023 | 48:8D0D DE9B0500         | lea rcx,qword ptr ds:[7FF8D4A66C08]                           | rcx:sub_7FF8D49CF0E0+14, 00007FF8D4A66C08:"minkernel\\ntdll\\ldrinit.c"
00007FF8D4A0D02A | E8 8196F4FF              | call ntdll.7FF8D49566B0                                       |
00007FF8D4A0D02F | EB 32                    | jmp ntdll.7FF8D4A0D063                                        |
00007FF8D4A0D031 | 44:8B0425 3003FE7F       | mov r8d,dword ptr ds:[7FFE0330]                               |
00007FF8D4A0D039 | B9 40000000              | mov ecx,40                                                    | 40:'@'
00007FF8D4A0D03E | 48:8B15 CBC10B00         | mov rdx,qword ptr ds:[7FF8D4AC9210]                           |
00007FF8D4A0D045 | 41:8BC0                  | mov eax,r8d                                                   |
00007FF8D4A0D048 | 83E0 3F                  | and eax,3F                                                    |
00007FF8D4A0D04B | 8BDF                     | mov ebx,edi                                                   |
```

## After
```ASM
00007FF8D4A0CEA5 | EB 00                    | jmp ntdll.7FF8D4A0CEA7                                        | // [ x64AIT ] Jump to label/specified location
00007FF8D4A0CEA7 | 48:83C4 38               | add rsp,38                                                    | // [ x64AIT ] Add rsp to 38
00007FF8D4A0CEAB | C3                       | ret                                                           | // [ x64AIT ] Pop return address from stack and jump there
00007FF8D4A0CEAC | CC                       | int3                                                          |
00007FF8D4A0CEAD | CC                       | int3                                                          |
00007FF8D4A0CEAE | CC                       | int3                                                          |
00007FF8D4A0CEAF | CC                       | int3                                                          |
00007FF8D4A0CEB0 | CC                       | int3                                                          |
00007FF8D4A0CEB1 | CC                       | int3                                                          |
00007FF8D4A0CEB2 | CC                       | int3                                                          |
00007FF8D4A0CEB3 | CC                       | int3                                                          |
00007FF8D4A0CEB4 | 48:895C24 10             | mov qword ptr ss:[rsp+10],rbx                                 | // [ x64AIT ] Move ss:[rsp+10] to rbx
00007FF8D4A0CEB9 | 48:897424 18             | mov qword ptr ss:[rsp+18],rsi                                 | [rsp+18]:"LdrpInitializeProcess" // [ x64AIT ] Move ss:[rsp+18] to rsi
00007FF8D4A0CEBE | 55                       | push rbp                                                      | // [ x64AIT ] Push EMPTY_SOURCE onto stack
00007FF8D4A0CEBF | 57                       | push rdi                                                      | rdi:"minkernel\\ntdll\\ldrinit.c" // [ x64AIT ] Push EMPTY_SOURCE onto stack
00007FF8D4A0CEC0 | 41:56                    | push r14                                                      | // [ x64AIT ] Push EMPTY_SOURCE onto stack
00007FF8D4A0CEC2 | 48:8DAC24 00FFFFFF       | lea rbp,qword ptr ss:[rsp-100]                                | // [ x64AIT ] Load effective address of rbp into qword
00007FF8D4A0CECA | 48:81EC 00020000         | sub rsp,200                                                   | // [ x64AIT ] Subtract rsp from 200
00007FF8D4A0CED1 | 48:8B05 48F60B00         | mov rax,qword ptr ds:[7FF8D4ACC520]                           | // [ x64AIT ] Move rax to qword
00007FF8D4A0CED8 | 48:33C4                  | xor rax,rsp                                                   | // [ x64AIT ] Bitwise XOR rsp by rax
00007FF8D4A0CEDB | 48:8985 F0000000         | mov qword ptr ss:[rbp+F0],rax                                 | // [ x64AIT ] Move ss:[rbp+F0] to rax
00007FF8D4A0CEE2 | 4C:8B05 27C30B00         | mov r8,qword ptr ds:[7FF8D4AC9210]                            | // [ x64AIT ] Move r8 to qword
00007FF8D4A0CEE9 | 48:8D05 E0AF0500         | lea rax,qword ptr ds:[7FF8D4A67ED0]                           | 00007FF8D4A67ED0:L"apphelp.dll" // [ x64AIT ] Load effective address of rax into qword
00007FF8D4A0CEF0 | 33FF                     | xor edi,edi                                                   | // [ x64AIT ] Bitwise XOR edi by edi
00007FF8D4A0CEF2 | 48:894424 50             | mov qword ptr ss:[rsp+50],rax                                 | // [ x64AIT ] Move ss:[rsp+50] to rax
00007FF8D4A0CEF7 | C74424 48 16001800       | mov dword ptr ss:[rsp+48],180016                              | // [ x64AIT ] Move ss:[rsp+48] to 180016
00007FF8D4A0CEFF | 48:8D4424 70             | lea rax,qword ptr ss:[rsp+70]                                 | [rsp+70]:L"ÂÄ" // [ x64AIT ] Load effective address of rax into qword
00007FF8D4A0CF04 | 48:894424 68             | mov qword ptr ss:[rsp+68],rax                                 | // [ x64AIT ] Move ss:[rsp+68] to rax
00007FF8D4A0CF09 | 48:8BF1                  | mov rsi,rcx                                                   | rcx:sub_7FF8D49CF0E0+14 // [ x64AIT ] Move rsi to rcx
00007FF8D4A0CF0C | C74424 60 00000001       | mov dword ptr ss:[rsp+60],1000000                             | // [ x64AIT ] Move ss:[rsp+60] to 1000000
00007FF8D4A0CF14 | 41:BE 00010000           | mov r14d,100                                                  | // [ x64AIT ] Move r14d to 100
00007FF8D4A0CF1A | 66:897C24 70             | mov word ptr ss:[rsp+70],di                                   | // [ x64AIT ] Move ss:[rsp+70] to di
00007FF8D4A0CF1F | 4D:85C0                  | test r8,r8                                                    | // [ x64AIT ] Set condition codes according to r8 & r8
00007FF8D4A0CF22 | 74 2B                    | je ntdll.7FF8D4A0CF4F                                         | // [ x64AIT ] Jump if equal/zero
00007FF8D4A0CF24 | 8B1425 3003FE7F          | mov edx,dword ptr ds:[7FFE0330]                               | // [ x64AIT ] Move edx to dword
00007FF8D4A0CF2B | 8D4F 40                  | lea ecx,qword ptr ds:[rdi+40]                                 | // [ x64AIT ] Load effective address of ecx into qword
00007FF8D4A0CF2E | 8BC2                     | mov eax,edx                                                   | // [ x64AIT ] Move eax to edx
00007FF8D4A0CF30 | 83E0 3F                  | and eax,3F                                                    | // [ x64AIT ] Bitwise AND 3F by eax
00007FF8D4A0CF33 | 2BC8                     | sub ecx,eax                                                   | // [ x64AIT ] Subtract ecx from eax
00007FF8D4A0CF35 | 8BC2                     | mov eax,edx                                                   | // [ x64AIT ] Move eax to edx
00007FF8D4A0CF37 | 49:D3C8                  | ror r8,cl                                                     |
00007FF8D4A0CF3A | 4C:33C0                  | xor r8,rax                                                    | // [ x64AIT ] Bitwise XOR rax by r8
00007FF8D4A0CF3D | B8 010000C0              | mov eax,C0000001                                              | // [ x64AIT ] Move eax to C0000001
00007FF8D4A0CF42 | 4C:8906                  | mov qword ptr ds:[rsi],r8                                     | // [ x64AIT ] Move ds:[rsi] to r8
00007FF8D4A0CF45 | 0F44F8                   | cmove edi,eax                                                 | // [ x64AIT ] Move if equal/zero
00007FF8D4A0CF48 | 8BDF                     | mov ebx,edi                                                   | // [ x64AIT ] Move ebx to edi
00007FF8D4A0CF4A | E9 28010000              | jmp ntdll.7FF8D4A0D077                                        | // [ x64AIT ] Jump to label/specified location
00007FF8D4A0CF4F | 48:8D5424 48             | lea rdx,qword ptr ss:[rsp+48]                                 | // [ x64AIT ] Load effective address of rdx into qword
00007FF8D4A0CF54 | 48:8D4C24 60             | lea rcx,qword ptr ss:[rsp+60]                                 | rcx:sub_7FF8D49CF0E0+14 // [ x64AIT ] Load effective address of rcx into qword
00007FF8D4A0CF59 | E8 86C3F9FF              | call <ntdll.sub_7FF8D49A92E4>                                 | // [ x64AIT ] Push return address and jump to label/specified location
00007FF8D4A0CF5E | 8BD8                     | mov ebx,eax                                                   | // [ x64AIT ] Move ebx to eax
00007FF8D4A0CF60 | 85C0                     | test eax,eax                                                  | // [ x64AIT ] Set condition codes according to eax & eax
00007FF8D4A0CF62 | 0F88 FB000000            | js ntdll.7FF8D4A0D063                                         |
00007FF8D4A0CF68 | 4C:8D45 70               | lea r8,qword ptr ss:[rbp+70]                                  | // [ x64AIT ] Load effective address of r8 into qword
00007FF8D4A0CF6C | BA 01400000              | mov edx,4001                                                  | // [ x64AIT ] Move edx to 4001
00007FF8D4A0CF71 | 33C9                     | xor ecx,ecx                                                   | // [ x64AIT ] Bitwise XOR ecx by ecx
00007FF8D4A0CF73 | E8 6CDBF4FF              | call ntdll.7FF8D495AAE4                                       | // [ x64AIT ] Push return address and jump to label/specified location
00007FF8D4A0CF78 | 4C:8D4C24 40             | lea r9,qword ptr ss:[rsp+40]                                  | [rsp+40]:L"KnownDllPath" // [ x64AIT ] Load effective address of r9 into qword
00007FF8D4A0CF7D | 45:33C0                  | xor r8d,r8d                                                   | // [ x64AIT ] Bitwise XOR r8d by r8d
00007FF8D4A0CF80 | 48:8D55 70               | lea rdx,qword ptr ss:[rbp+70]                                 | // [ x64AIT ] Load effective address of rdx into qword
00007FF8D4A0CF84 | 48:8D4C24 60             | lea rcx,qword ptr ss:[rsp+60]                                 | rcx:sub_7FF8D49CF0E0+14 // [ x64AIT ] Load effective address of rcx into qword
00007FF8D4A0CF89 | E8 5EBCF3FF              | call <ntdll.sub_7FF8D4948BEC>                                 | // [ x64AIT ] Push return address and jump to label/specified location
00007FF8D4A0CF8E | 8BD8                     | mov ebx,eax                                                   | // [ x64AIT ] Move ebx to eax
00007FF8D4A0CF90 | 40:38BD EC000000         | cmp byte ptr ss:[rbp+EC],dil                                  | // [ x64AIT ] Set condition codes according to ss:[rbp+EC] - dil
00007FF8D4A0CF97 | 74 09                    | je ntdll.7FF8D4A0CFA2                                         | // [ x64AIT ] Jump if equal/zero
00007FF8D4A0CF99 | 48:8B4D 70               | mov rcx,qword ptr ss:[rbp+70]                                 | rcx:sub_7FF8D49CF0E0+14 // [ x64AIT ] Move rcx to qword
00007FF8D4A0CF9D | E8 3E58F5FF              | call <ntdll.RtlReleasePath>                                   | // [ x64AIT ] Push return address and jump to label/specified location
00007FF8D4A0CFA2 | 85DB                     | test ebx,ebx                                                  | // [ x64AIT ] Set condition codes according to ebx & ebx
00007FF8D4A0CFA4 | 79 3A                    | jns ntdll.7FF8D4A0CFE0                                        | // [ x64AIT ] Jump if nonnegative
00007FF8D4A0CFA6 | 48:8D4424 60             | lea rax,qword ptr ss:[rsp+60]                                 | // [ x64AIT ] Load effective address of rax into qword
00007FF8D4A0CFAB | 895C24 30                | mov dword ptr ss:[rsp+30],ebx                                 | // [ x64AIT ] Move ss:[rsp+30] to ebx
00007FF8D4A0CFAF | 48:894424 28             | mov qword ptr ss:[rsp+28],rax                                 | // [ x64AIT ] Move ss:[rsp+28] to rax
00007FF8D4A0CFB4 | 4C:8D05 B5F90600         | lea r8,qword ptr ds:[7FF8D4A7C970]                            | 00007FF8D4A7C970:"LdrpGetProcApphelpCheckModule" // [ x64AIT ] Load effective address of r8 into qword
00007FF8D4A0CFBB | 48:8D05 6EF90600         | lea rax,qword ptr ds:[7FF8D4A7C930]                           | 00007FF8D4A7C930:"Loading the shim engine DLL \"%wZ\" failed with status 0x%08lx\n" // [ x64AIT ] Load effective address of rax into qword
00007FF8D4A0CFC2 | 45:33C9                  | xor r9d,r9d                                                   | // [ x64AIT ] Bitwise XOR r9d by r9d
00007FF8D4A0CFC5 | BA E70D0000              | mov edx,DE7                                                   | // [ x64AIT ] Move edx to DE7
00007FF8D4A0CFCA | 48:894424 20             | mov qword ptr ss:[rsp+20],rax                                 | // [ x64AIT ] Move ss:[rsp+20] to rax
00007FF8D4A0CFCF | 48:8D0D 329C0500         | lea rcx,qword ptr ds:[7FF8D4A66C08]                           | rcx:sub_7FF8D49CF0E0+14, 00007FF8D4A66C08:"minkernel\\ntdll\\ldrinit.c" // [ x64AIT ] Load effective address of rcx:sub_7FF8D49CF0E0+14 into 
00007FF8D4A0CFD6 | E8 D596F4FF              | call ntdll.7FF8D49566B0                                       | // [ x64AIT ] Push return address and jump to label/specified location
00007FF8D4A0CFDB | E9 83000000              | jmp ntdll.7FF8D4A0D063                                        | // [ x64AIT ] Jump to label/specified location
00007FF8D4A0CFE0 | 48:8B4424 40             | mov rax,qword ptr ss:[rsp+40]                                 | [rsp+40]:L"KnownDllPath" // [ x64AIT ] Move rax to qword
00007FF8D4A0CFE5 | 44:0970 68               | or dword ptr ds:[rax+68],r14d                                 | // [ x64AIT ] Bitwise OR r14d by ds:[rax+68]
00007FF8D4A0CFE9 | 48:8B4424 40             | mov rax,qword ptr ss:[rsp+40]                                 | [rsp+40]:L"KnownDllPath" // [ x64AIT ] Move rax to qword
00007FF8D4A0CFEE | 48:8B48 30               | mov rcx,qword ptr ds:[rax+30]                                 | rcx:sub_7FF8D49CF0E0+14 // [ x64AIT ] Move rcx to qword
00007FF8D4A0CFF2 | 48:890D 6F730A00         | mov qword ptr ds:[7FF8D4AB4368],rcx                           | rcx:sub_7FF8D49CF0E0+14 // [ x64AIT ] Move ds:[7FF8D4AB4368] to rcx
00007FF8D4A0CFF9 | E8 5AC3F9FF              | call ntdll.7FF8D49A9358                                       | // [ x64AIT ] Push return address and jump to label/specified location
00007FF8D4A0CFFE | 8BD8                     | mov ebx,eax                                                   | // [ x64AIT ] Move ebx to eax
00007FF8D4A0D000 | 85C0                     | test eax,eax                                                  | // [ x64AIT ] Set condition codes according to eax & eax
00007FF8D4A0D002 | 79 2D                    | jns ntdll.7FF8D4A0D031                                        | // [ x64AIT ] Jump if nonnegative
00007FF8D4A0D004 | 894424 28                | mov dword ptr ss:[rsp+28],eax                                 | // [ x64AIT ] Move ss:[rsp+28] to eax
00007FF8D4A0D008 | 4C:8D05 61F90600         | lea r8,qword ptr ds:[7FF8D4A7C970]                            | 00007FF8D4A7C970:"LdrpGetProcApphelpCheckModule" // [ x64AIT ] Load effective address of r8 into qword
00007FF8D4A0D00F | 48:8D05 32F80600         | lea rax,qword ptr ds:[7FF8D4A7C848]                           | 00007FF8D4A7C848:"Getting the shim engine exports failed with status 0x%08lx\n" // [ x64AIT ] Load effective address of rax into qword
00007FF8D4A0D016 | 45:33C9                  | xor r9d,r9d                                                   | // [ x64AIT ] Bitwise XOR r9d by r9d
00007FF8D4A0D019 | BA F20D0000              | mov edx,DF2                                                   | // [ x64AIT ] Move edx to DF2
00007FF8D4A0D01E | 48:894424 20             | mov qword ptr ss:[rsp+20],rax                                 | // [ x64AIT ] Move ss:[rsp+20] to rax
00007FF8D4A0D023 | 48:8D0D DE9B0500         | lea rcx,qword ptr ds:[7FF8D4A66C08]                           | rcx:sub_7FF8D49CF0E0+14, 00007FF8D4A66C08:"minkernel\\ntdll\\ldrinit.c" // [ x64AIT ] Load effective address of rcx:sub_7FF8D49CF0E0+14 into 
00007FF8D4A0D02A | E8 8196F4FF              | call ntdll.7FF8D49566B0                                       | // [ x64AIT ] Push return address and jump to label/specified location
00007FF8D4A0D02F | EB 32                    | jmp ntdll.7FF8D4A0D063                                        | // [ x64AIT ] Jump to label/specified location
00007FF8D4A0D031 | 44:8B0425 3003FE7F       | mov r8d,dword ptr ds:[7FFE0330]                               | // [ x64AIT ] Move r8d to dword
00007FF8D4A0D039 | B9 40000000              | mov ecx,40                                                    | 40:'@' // [ x64AIT ] Move ecx to 40
00007FF8D4A0D03E | 48:8B15 CBC10B00         | mov rdx,qword ptr ds:[7FF8D4AC9210]                           | // [ x64AIT ] Move rdx to qword
00007FF8D4A0D045 | 41:8BC0                  | mov eax,r8d                                                   | // [ x64AIT ] Move eax to r8d
00007FF8D4A0D048 | 83E0 3F                  | and eax,3F                                                    | // [ x64AIT ] Bitwise AND 3F by eax
00007FF8D4A0D04B | 8BDF                     | mov ebx,edi                                                   | // [ x64AIT ] Move ebx to edi

```