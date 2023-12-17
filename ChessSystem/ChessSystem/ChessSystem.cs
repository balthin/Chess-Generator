using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using ChessImages;

namespace ChessSystem
{
    public enum Figures { WhiteKing, WhiteQueen, WhiteRook, WhiteBishop, WhiteKnight, WhitePawn, 
        BlackKing, BlackQueen, BlackRook, BlackBishop, BlackKnight, BlackPawn }
    public enum Relocation { Diagonal = 1, Ortogonal = 2, Faraway = 4 }
    public enum Coloration { White = 8, Black = 16 }
    enum W
    {
        K = Coloration.White + Relocation.Diagonal + Relocation.Ortogonal,
        Q = Coloration.White + Relocation.Diagonal + Relocation.Ortogonal + Relocation.Faraway,
        R = Coloration.White + Relocation.Ortogonal + Relocation.Faraway,
        B = Coloration.White + Relocation.Diagonal + Relocation.Faraway,
        N = Coloration.White + Relocation.Ortogonal,
        P = Coloration.White + Relocation.Diagonal
    }
    enum B
    {
        K = Coloration.Black + Relocation.Diagonal + Relocation.Ortogonal,
        Q = Coloration.Black + Relocation.Diagonal + Relocation.Ortogonal + Relocation.Faraway,
        R = Coloration.Black + Relocation.Ortogonal + Relocation.Faraway,
        B = Coloration.Black + Relocation.Diagonal + Relocation.Faraway,
        N = Coloration.Black + Relocation.Ortogonal,
        P = Coloration.Black + Relocation.Diagonal
    }
    public enum S 
    {
        H1 = 00 << 5, G1 = 01 << 5, F1 = 02 << 5, E1 = 03 << 5, D1 = 04 << 5, C1 = 05 << 5, B1 = 06 << 5, A1 = 07 << 5,
        H2 = 08 << 5, G2 = 09 << 5, F2 = 10 << 5, E2 = 11 << 5, D2 = 12 << 5, C2 = 13 << 5, B2 = 14 << 5, A2 = 15 << 5,
        H3 = 16 << 5, G3 = 17 << 5, F3 = 18 << 5, E3 = 19 << 5, D3 = 20 << 5, C3 = 21 << 5, B3 = 22 << 5, A3 = 23 << 5,
        H4 = 24 << 5, G4 = 25 << 5, F4 = 26 << 5, E4 = 27 << 5, D4 = 28 << 5, C4 = 29 << 5, B4 = 30 << 5, A4 = 31 << 5,
        H5 = 32 << 5, G5 = 33 << 5, F5 = 34 << 5, E5 = 35 << 5, D5 = 36 << 5, C5 = 37 << 5, B5 = 38 << 5, A5 = 39 << 5,
        H6 = 40 << 5, G6 = 41 << 5, F6 = 42 << 5, E6 = 43 << 5, D6 = 44 << 5, C6 = 45 << 5, B6 = 46 << 5, A6 = 47 << 5,
        H7 = 48 << 5, G7 = 49 << 5, F7 = 50 << 5, E7 = 51 << 5, D7 = 52 << 5, C7 = 53 << 5, B7 = 54 << 5, A7 = 55 << 5,
        H8 = 56 << 5, G8 = 57 << 5, F8 = 58 << 5, E8 = 59 << 5, D8 = 60 << 5, C8 = 61 << 5, B8 = 62 << 5, A8 = 63 << 5 
    }
    public enum ChessItem
    {
        WKH1 = W.K + S.H1, WKG1 = W.K + S.G1, WKF1 = W.K + S.F1, WKE1 = W.K + S.E1, WKD1 = W.K + S.D1, WKC1 = W.K + S.C1, WKB1 = W.K + S.B1, WKA1 = W.K + S.A1,
        WKH2 = W.K + S.H2, WKG2 = W.K + S.G2, WKF2 = W.K + S.F2, WKE2 = W.K + S.E2, WKD2 = W.K + S.D2, WKC2 = W.K + S.C2, WKB2 = W.K + S.B2, WKA2 = W.K + S.A2,
        WKH3 = W.K + S.H3, WKG3 = W.K + S.G3, WKF3 = W.K + S.F3, WKE3 = W.K + S.E3, WKD3 = W.K + S.D3, WKC3 = W.K + S.C3, WKB3 = W.K + S.B3, WKA3 = W.K + S.A3,
        WKH4 = W.K + S.H4, WKG4 = W.K + S.G4, WKF4 = W.K + S.F4, WKE4 = W.K + S.E4, WKD4 = W.K + S.D4, WKC4 = W.K + S.C4, WKB4 = W.K + S.B4, WKA4 = W.K + S.A4,
        WKH5 = W.K + S.H5, WKG5 = W.K + S.G5, WKF5 = W.K + S.F5, WKE5 = W.K + S.E5, WKD5 = W.K + S.D5, WKC5 = W.K + S.C5, WKB5 = W.K + S.B5, WKA5 = W.K + S.A5,
        WKH6 = W.K + S.H6, WKG6 = W.K + S.G6, WKF6 = W.K + S.F6, WKE6 = W.K + S.E6, WKD6 = W.K + S.D6, WKC6 = W.K + S.C6, WKB6 = W.K + S.B6, WKA6 = W.K + S.A6,
        WKH7 = W.K + S.H7, WKG7 = W.K + S.G7, WKF7 = W.K + S.F7, WKE7 = W.K + S.E7, WKD7 = W.K + S.D7, WKC7 = W.K + S.C7, WKB7 = W.K + S.B7, WKA7 = W.K + S.A7,
        WKH8 = W.K + S.H8, WKG8 = W.K + S.G8, WKF8 = W.K + S.F8, WKE8 = W.K + S.E8, WKD8 = W.K + S.D8, WKC8 = W.K + S.C8, WKB8 = W.K + S.B8, WKA8 = W.K + S.A8,

        WQH1 = W.Q + S.H1, WQG1 = W.Q + S.G1, WQF1 = W.Q + S.F1, WQE1 = W.Q + S.E1, WQD1 = W.Q + S.D1, WQC1 = W.Q + S.C1, WQB1 = W.Q + S.B1, WQA1 = W.Q + S.A1,
        WQH2 = W.Q + S.H2, WQG2 = W.Q + S.G2, WQF2 = W.Q + S.F2, WQE2 = W.Q + S.E2, WQD2 = W.Q + S.D2, WQC2 = W.Q + S.C2, WQB2 = W.Q + S.B2, WQA2 = W.Q + S.A2,
        WQH3 = W.Q + S.H3, WQG3 = W.Q + S.G3, WQF3 = W.Q + S.F3, WQE3 = W.Q + S.E3, WQD3 = W.Q + S.D3, WQC3 = W.Q + S.C3, WQB3 = W.Q + S.B3, WQA3 = W.Q + S.A3,
        WQH4 = W.Q + S.H4, WQG4 = W.Q + S.G4, WQF4 = W.Q + S.F4, WQE4 = W.Q + S.E4, WQD4 = W.Q + S.D4, WQC4 = W.Q + S.C4, WQB4 = W.Q + S.B4, WQA4 = W.Q + S.A4,
        WQH5 = W.Q + S.H5, WQG5 = W.Q + S.G5, WQF5 = W.Q + S.F5, WQE5 = W.Q + S.E5, WQD5 = W.Q + S.D5, WQC5 = W.Q + S.C5, WQB5 = W.Q + S.B5, WQA5 = W.Q + S.A5,
        WQH6 = W.Q + S.H6, WQG6 = W.Q + S.G6, WQF6 = W.Q + S.F6, WQE6 = W.Q + S.E6, WQD6 = W.Q + S.D6, WQC6 = W.Q + S.C6, WQB6 = W.Q + S.B6, WQA6 = W.Q + S.A6,
        WQH7 = W.Q + S.H7, WQG7 = W.Q + S.G7, WQF7 = W.Q + S.F7, WQE7 = W.Q + S.E7, WQD7 = W.Q + S.D7, WQC7 = W.Q + S.C7, WQB7 = W.Q + S.B7, WQA7 = W.Q + S.A7,
        WQH8 = W.Q + S.H8, WQG8 = W.Q + S.G8, WQF8 = W.Q + S.F8, WQE8 = W.Q + S.E8, WQD8 = W.Q + S.D8, WQC8 = W.Q + S.C8, WQB8 = W.Q + S.B8, WQA8 = W.Q + S.A8,
        /*
        WKH1 = W.R + S.H1, WKG1 = W.R + S.G1, WKF1 = W.R + S.F1, WKE1 = W.R + S.E1, WKD1 = W.R + S.D1, WKC1 = W.R + S.C1, WKB1 = W.R + S.B1, WKA1 = W.R + S.A1,
        WKH2 = W.R + S.H2, WKG2 = W.R + S.G2, WKF2 = W.R + S.F2, WKE2 = W.R + S.E2, WKD2 = W.R + S.D2, WKC2 = W.R + S.C2, WKB2 = W.R + S.B2, WKA2 = W.R + S.A2,
        WKH3 = W.R + S.H3, WKG3 = W.R + S.G3, WKF3 = W.R + S.F3, WKE3 = W.R + S.E3, WKD3 = W.R + S.D3, WKC3 = W.R + S.C3, WKB3 = W.R + S.B3, WKA3 = W.R + S.A3,
        WKH4 = W.R + S.H4, WKG4 = W.R + S.G4, WKF4 = W.R + S.F4, WKE4 = W.R + S.E4, WKD4 = W.R + S.D4, WKC4 = W.R + S.C4, WKB4 = W.R + S.B4, WKA4 = W.R + S.A4,
        WKH5 = W.R + S.H5, WKG5 = W.R + S.G5, WKF5 = W.R + S.F5, WKE5 = W.R + S.E5, WKD5 = W.R + S.D5, WKC5 = W.R + S.C5, WKB5 = W.R + S.B5, WKA5 = W.R + S.A5,
        WKH6 = W.R + S.H6, WKG6 = W.R + S.G6, WKF6 = W.R + S.F6, WKE6 = W.R + S.E6, WKD6 = W.R + S.D6, WKC6 = W.R + S.C6, WKB6 = W.R + S.B6, WKA6 = W.R + S.A6,
        WKH7 = W.R + S.H7, WKG7 = W.R + S.G7, WKF7 = W.R + S.F7, WKE7 = W.R + S.E7, WKD7 = W.R + S.D7, WKC7 = W.R + S.C7, WKB7 = W.R + S.B7, WKA7 = W.R + S.A7,
        WKH8 = W.R + S.H8, WKG8 = W.R + S.G8, WKF8 = W.R + S.F8, WKE8 = W.R + S.E8, WKD8 = W.R + S.D8, WKC8 = W.R + S.C8, WKB8 = W.R + S.B8, WKA8 = W.R + S.A8,

        WKH1 = W.K + S.H1, WKG1 = W.K + S.G1, WKF1 = W.K + S.F1, WKE1 = W.K + S.E1, WKD1 = W.K + S.D1, WKC1 = W.K + S.C1, WKB1 = W.K + S.B1, WKA1 = W.K + S.A1,
        WKH2 = W.K + S.H2, WKG2 = W.K + S.G2, WKF2 = W.K + S.F2, WKE2 = W.K + S.E2, WKD2 = W.K + S.D2, WKC2 = W.K + S.C2, WKB2 = W.K + S.B2, WKA2 = W.K + S.A2,
        WKH3 = W.K + S.H3, WKG3 = W.K + S.G3, WKF3 = W.K + S.F3, WKE3 = W.K + S.E3, WKD3 = W.K + S.D3, WKC3 = W.K + S.C3, WKB3 = W.K + S.B3, WKA3 = W.K + S.A3,
        WKH4 = W.K + S.H4, WKG4 = W.K + S.G4, WKF4 = W.K + S.F4, WKE4 = W.K + S.E4, WKD4 = W.K + S.D4, WKC4 = W.K + S.C4, WKB4 = W.K + S.B4, WKA4 = W.K + S.A4,
        WKH5 = W.K + S.H5, WKG5 = W.K + S.G5, WKF5 = W.K + S.F5, WKE5 = W.K + S.E5, WKD5 = W.K + S.D5, WKC5 = W.K + S.C5, WKB5 = W.K + S.B5, WKA5 = W.K + S.A5,
        WKH6 = W.K + S.H6, WKG6 = W.K + S.G6, WKF6 = W.K + S.F6, WKE6 = W.K + S.E6, WKD6 = W.K + S.D6, WKC6 = W.K + S.C6, WKB6 = W.K + S.B6, WKA6 = W.K + S.A6,
        WKH7 = W.K + S.H7, WKG7 = W.K + S.G7, WKF7 = W.K + S.F7, WKE7 = W.K + S.E7, WKD7 = W.K + S.D7, WKC7 = W.K + S.C7, WKB7 = W.K + S.B7, WKA7 = W.K + S.A7,
        WKH8 = W.K + S.H8, WKG8 = W.K + S.G8, WKF8 = W.K + S.F8, WKE8 = W.K + S.E8, WKD8 = W.K + S.D8, WKC8 = W.K + S.C8, WKB8 = W.K + S.B8, WKA8 = W.K + S.A8,

        WKH1 = W.K + S.H1, WKG1 = W.K + S.G1, WKF1 = W.K + S.F1, WKE1 = W.K + S.E1, WKD1 = W.K + S.D1, WKC1 = W.K + S.C1, WKB1 = W.K + S.B1, WKA1 = W.K + S.A1,
        WKH2 = W.K + S.H2, WKG2 = W.K + S.G2, WKF2 = W.K + S.F2, WKE2 = W.K + S.E2, WKD2 = W.K + S.D2, WKC2 = W.K + S.C2, WKB2 = W.K + S.B2, WKA2 = W.K + S.A2,
        WKH3 = W.K + S.H3, WKG3 = W.K + S.G3, WKF3 = W.K + S.F3, WKE3 = W.K + S.E3, WKD3 = W.K + S.D3, WKC3 = W.K + S.C3, WKB3 = W.K + S.B3, WKA3 = W.K + S.A3,
        WKH4 = W.K + S.H4, WKG4 = W.K + S.G4, WKF4 = W.K + S.F4, WKE4 = W.K + S.E4, WKD4 = W.K + S.D4, WKC4 = W.K + S.C4, WKB4 = W.K + S.B4, WKA4 = W.K + S.A4,
        WKH5 = W.K + S.H5, WKG5 = W.K + S.G5, WKF5 = W.K + S.F5, WKE5 = W.K + S.E5, WKD5 = W.K + S.D5, WKC5 = W.K + S.C5, WKB5 = W.K + S.B5, WKA5 = W.K + S.A5,
        WKH6 = W.K + S.H6, WKG6 = W.K + S.G6, WKF6 = W.K + S.F6, WKE6 = W.K + S.E6, WKD6 = W.K + S.D6, WKC6 = W.K + S.C6, WKB6 = W.K + S.B6, WKA6 = W.K + S.A6,
        WKH7 = W.K + S.H7, WKG7 = W.K + S.G7, WKF7 = W.K + S.F7, WKE7 = W.K + S.E7, WKD7 = W.K + S.D7, WKC7 = W.K + S.C7, WKB7 = W.K + S.B7, WKA7 = W.K + S.A7,
        WKH8 = W.K + S.H8, WKG8 = W.K + S.G8, WKF8 = W.K + S.F8, WKE8 = W.K + S.E8, WKD8 = W.K + S.D8, WKC8 = W.K + S.C8, WKB8 = W.K + S.B8, WKA8 = W.K + S.A8,

        WKH1 = W.K + S.H1, WKG1 = W.K + S.G1, WKF1 = W.K + S.F1, WKE1 = W.K + S.E1, WKD1 = W.K + S.D1, WKC1 = W.K + S.C1, WKB1 = W.K + S.B1, WKA1 = W.K + S.A1,
        WKH2 = W.K + S.H2, WKG2 = W.K + S.G2, WKF2 = W.K + S.F2, WKE2 = W.K + S.E2, WKD2 = W.K + S.D2, WKC2 = W.K + S.C2, WKB2 = W.K + S.B2, WKA2 = W.K + S.A2,
        WKH3 = W.K + S.H3, WKG3 = W.K + S.G3, WKF3 = W.K + S.F3, WKE3 = W.K + S.E3, WKD3 = W.K + S.D3, WKC3 = W.K + S.C3, WKB3 = W.K + S.B3, WKA3 = W.K + S.A3,
        WKH4 = W.K + S.H4, WKG4 = W.K + S.G4, WKF4 = W.K + S.F4, WKE4 = W.K + S.E4, WKD4 = W.K + S.D4, WKC4 = W.K + S.C4, WKB4 = W.K + S.B4, WKA4 = W.K + S.A4,
        WKH5 = W.K + S.H5, WKG5 = W.K + S.G5, WKF5 = W.K + S.F5, WKE5 = W.K + S.E5, WKD5 = W.K + S.D5, WKC5 = W.K + S.C5, WKB5 = W.K + S.B5, WKA5 = W.K + S.A5,
        WKH6 = W.K + S.H6, WKG6 = W.K + S.G6, WKF6 = W.K + S.F6, WKE6 = W.K + S.E6, WKD6 = W.K + S.D6, WKC6 = W.K + S.C6, WKB6 = W.K + S.B6, WKA6 = W.K + S.A6,
        WKH7 = W.K + S.H7, WKG7 = W.K + S.G7, WKF7 = W.K + S.F7, WKE7 = W.K + S.E7, WKD7 = W.K + S.D7, WKC7 = W.K + S.C7, WKB7 = W.K + S.B7, WKA7 = W.K + S.A7,
        WKH8 = W.K + S.H8, WKG8 = W.K + S.G8, WKF8 = W.K + S.F8, WKE8 = W.K + S.E8, WKD8 = W.K + S.D8, WKC8 = W.K + S.C8, WKB8 = W.K + S.B8, WKA8 = W.K + S.A8,
        
        BKH1 = 0x00B, BKG1 = 0x00B, BKF1 = 0x00B, BKE1 = 0x00B, BKD1 = 0x00B, BKC1 = 0x00B, BKB1 = 0x00B, BKA1 = 0x00B,
        BKH2 = 0x00B, BKG2 = 0x00B, BKF2 = 0x00B, BKE2 = 0x00B, BKD2 = 0x00B, BKC2 = 0x00B, BKB2 = 0x00B, BKA2 = 0x00B,
        BKH3 = 0x00B, BKG3 = 0x00B, BKF3 = 0x00B, BKE3 = 0x00B, BKD3 = 0x00B, BKC3 = 0x00B, BKB3 = 0x00B, BKA3 = 0x00B,
        BKH4 = 0x00B, BKG4 = 0x00B, BKF4 = 0x00B, BKE4 = 0x00B, BKD4 = 0x00B, BKC4 = 0x00B, BKB4 = 0x00B, BKA4 = 0x00B,
        BKH5 = 0x00B, BKG5 = 0x00B, BKF5 = 0x00B, BKE5 = 0x00B, BKD5 = 0x00B, BKC5 = 0x00B, BKB5 = 0x00B, BKA5 = 0x00B,
        BKH6 = 0x00B, BKG6 = 0x00B, BKF6 = 0x00B, BKE6 = 0x00B, BKD6 = 0x00B, BKC6 = 0x00B, BKB6 = 0x00B, BKA6 = 0x00B,
        BKH7 = 0x00B, BKG7 = 0x00B, BKF7 = 0x00B, BKE7 = 0x00B, BKD7 = 0x00B, BKC7 = 0x00B, BKB7 = 0x00B, BKA7 = 0x00B,
        BKH8 = 0x00B, BKG8 = 0x00B, BKF8 = 0x00B, BKE8 = 0x00B, BKD8 = 0x00B, BKC8 = 0x00B, BKB8 = 0x00B, BKA8 = 0x00B,
        
        BQH1 = 0x00B, BQG1 = 0x00B, BQF1 = 0x00B, BQE1 = 0x00B, BQD1 = 0x00B, BQC1 = 0x00B, BQB1 = 0x00B, BQA1 = 0x00B,
        BQH2 = 0x00B, BQG2 = 0x00B, BQF2 = 0x00B, BQE2 = 0x00B, BQD2 = 0x00B, BQC2 = 0x00B, BQB2 = 0x00B, BQA2 = 0x00B,
        BQH3 = 0x00B, BQG3 = 0x00B, BQF3 = 0x00B, BQE3 = 0x00B, BQD3 = 0x00B, BQC3 = 0x00B, BQB3 = 0x00B, BQA3 = 0x00B,
        BQH4 = 0x00B, BQG4 = 0x00B, BQF4 = 0x00B, BQE4 = 0x00B, BQD4 = 0x00B, BQC4 = 0x00B, BQB4 = 0x00B, BQA4 = 0x00B,
        BQH5 = 0x00B, BQG5 = 0x00B, BQF5 = 0x00B, BQE5 = 0x00B, BQD5 = 0x00B, BQC5 = 0x00B, BQB5 = 0x00B, BQA5 = 0x00B,
        BQH6 = 0x00B, BQG6 = 0x00B, BQF6 = 0x00B, BQE6 = 0x00B, BQD6 = 0x00B, BQC6 = 0x00B, BQB6 = 0x00B, BQA6 = 0x00B,
        BQH7 = 0x00B, BQG7 = 0x00B, BQF7 = 0x00B, BQE7 = 0x00B, BQD7 = 0x00B, BQC7 = 0x00B, BQB7 = 0x00B, BQA7 = 0x00B,
        BQH8 = 0x00B, BQG8 = 0x00B, BQF8 = 0x00B, BQE8 = 0x00B, BQD8 = 0x00B, BQC8 = 0x00B, BQB8 = 0x00B, BQA8 = 0x00B,
        
        BRH1 = 0x00B, BRG1 = 0x00B, BRF1 = 0x00B, BRE1 = 0x00B, BRD1 = 0x00B, BRC1 = 0x00B, BRB1 = 0x00B, BRA1 = 0x00B,
        BRH2 = 0x00B, BRG2 = 0x00B, BRF2 = 0x00B, BRE2 = 0x00B, BRD2 = 0x00B, BRC2 = 0x00B, BRB2 = 0x00B, BRA2 = 0x00B,
        BRH3 = 0x00B, BRG3 = 0x00B, BRF3 = 0x00B, BRE3 = 0x00B, BRD3 = 0x00B, BRC3 = 0x00B, BRB3 = 0x00B, BRA3 = 0x00B,
        BRH4 = 0x00B, BRG4 = 0x00B, BRF4 = 0x00B, BRE4 = 0x00B, BRD4 = 0x00B, BRC4 = 0x00B, BRB4 = 0x00B, BRA4 = 0x00B,
        BRH5 = 0x00B, BRG5 = 0x00B, BRF5 = 0x00B, BRE5 = 0x00B, BRD5 = 0x00B, BRC5 = 0x00B, BRB5 = 0x00B, BRA5 = 0x00B,
        BRH6 = 0x00B, BRG6 = 0x00B, BRF6 = 0x00B, BRE6 = 0x00B, BRD6 = 0x00B, BRC6 = 0x00B, BRB6 = 0x00B, BRA6 = 0x00B,
        BRH7 = 0x00B, BRG7 = 0x00B, BRF7 = 0x00B, BRE7 = 0x00B, BRD7 = 0x00B, BRC7 = 0x00B, BRB7 = 0x00B, BRA7 = 0x00B,
        BRH8 = 0x00B, BRG8 = 0x00B, BRF8 = 0x00B, BRE8 = 0x00B, BRD8 = 0x00B, BRC8 = 0x00B, BRB8 = 0x00B, BRA8 = 0x00B,
        
        BBH1 = 0x00B, BBG1 = 0x00B, BBF1 = 0x00B, BBE1 = 0x00B, BBD1 = 0x00B, BBC1 = 0x00B, BBB1 = 0x00B, BBA1 = 0x00B,
        BBH2 = 0x00B, BBG2 = 0x00B, BBF2 = 0x00B, BBE2 = 0x00B, BBD2 = 0x00B, BBC2 = 0x00B, BBB2 = 0x00B, BBA2 = 0x00B,
        BBH3 = 0x00B, BBG3 = 0x00B, BBF3 = 0x00B, BBE3 = 0x00B, BBD3 = 0x00B, BBC3 = 0x00B, BBB3 = 0x00B, BBA3 = 0x00B,
        BBH4 = 0x00B, BBG4 = 0x00B, BBF4 = 0x00B, BBE4 = 0x00B, BBD4 = 0x00B, BBC4 = 0x00B, BBB4 = 0x00B, BBA4 = 0x00B,
        BBH5 = 0x00B, BBG5 = 0x00B, BBF5 = 0x00B, BBE5 = 0x00B, BBD5 = 0x00B, BBC5 = 0x00B, BBB5 = 0x00B, BBA5 = 0x00B,
        BBH6 = 0x00B, BBG6 = 0x00B, BBF6 = 0x00B, BBE6 = 0x00B, BBD6 = 0x00B, BBC6 = 0x00B, BBB6 = 0x00B, BBA6 = 0x00B,
        BBH7 = 0x00B, BBG7 = 0x00B, BBF7 = 0x00B, BBE7 = 0x00B, BBD7 = 0x00B, BBC7 = 0x00B, BBB7 = 0x00B, BBA7 = 0x00B,
        BBH8 = 0x00B, BBG8 = 0x00B, BBF8 = 0x00B, BBE8 = 0x00B, BBD8 = 0x00B, BBC8 = 0x00B, BBB8 = 0x00B, BBA8 = 0x00B,
        
        BNH1 = 0x00B, BNG1 = 0x00B, BNF1 = 0x00B, BNE1 = 0x00B, BND1 = 0x00B, BNC1 = 0x00B, BNB1 = 0x00B, BNA1 = 0x00B,
        BNH2 = 0x00B, BNG2 = 0x00B, BNF2 = 0x00B, BNE2 = 0x00B, BND2 = 0x00B, BNC2 = 0x00B, BNB2 = 0x00B, BNA2 = 0x00B,
        BNH3 = 0x00B, BNG3 = 0x00B, BNF3 = 0x00B, BNE3 = 0x00B, BND3 = 0x00B, BNC3 = 0x00B, BNB3 = 0x00B, BNA3 = 0x00B,
        BNH4 = 0x00B, BNG4 = 0x00B, BNF4 = 0x00B, BNE4 = 0x00B, BND4 = 0x00B, BNC4 = 0x00B, BNB4 = 0x00B, BNA4 = 0x00B,
        BNH5 = 0x00B, BNG5 = 0x00B, BNF5 = 0x00B, BNE5 = 0x00B, BND5 = 0x00B, BNC5 = 0x00B, BNB5 = 0x00B, BNA5 = 0x00B,
        BNH6 = 0x00B, BNG6 = 0x00B, BNF6 = 0x00B, BNE6 = 0x00B, BND6 = 0x00B, BNC6 = 0x00B, BNB6 = 0x00B, BNA6 = 0x00B,
        BNH7 = 0x00B, BNG7 = 0x00B, BNF7 = 0x00B, BNE7 = 0x00B, BND7 = 0x00B, BNC7 = 0x00B, BNB7 = 0x00B, BNA7 = 0x00B,
        BNH8 = 0x00B, BNG8 = 0x00B, BNF8 = 0x00B, BNE8 = 0x00B, BND8 = 0x00B, BNC8 = 0x00B, BNB8 = 0x00B, BNA8 = 0x00B,
        
        BPH1 = 0x00B, BPG1 = 0x00B, BPF1 = 0x00B, BPE1 = 0x00B, BPD1 = 0x00B, BPC1 = 0x00B, BPB1 = 0x00B, BPA1 = 0x00B,
        BPH2 = 0x00B, BPG2 = 0x00B, BPF2 = 0x00B, BPE2 = 0x00B, BPD2 = 0x00B, BPC2 = 0x00B, BPB2 = 0x00B, BPA2 = 0x00B,
        BPH3 = 0x00B, BPG3 = 0x00B, BPF3 = 0x00B, BPE3 = 0x00B, BPD3 = 0x00B, BPC3 = 0x00B, BPB3 = 0x00B, BPA3 = 0x00B,
        BPH4 = 0x00B, BPG4 = 0x00B, BPF4 = 0x00B, BPE4 = 0x00B, BPD4 = 0x00B, BPC4 = 0x00B, BPB4 = 0x00B, BPA4 = 0x00B,
        BPH5 = 0x00B, BPG5 = 0x00B, BPF5 = 0x00B, BPE5 = 0x00B, BPD5 = 0x00B, BPC5 = 0x00B, BPB5 = 0x00B, BPA5 = 0x00B,
        BPH6 = 0x00B, BPG6 = 0x00B, BPF6 = 0x00B, BPE6 = 0x00B, BPD6 = 0x00B, BPC6 = 0x00B, BPB6 = 0x00B, BPA6 = 0x00B,
        BPH7 = 0x00B, BPG7 = 0x00B, BPF7 = 0x00B, BPE7 = 0x00B, BPD7 = 0x00B, BPC7 = 0x00B, BPB7 = 0x00B, BPA7 = 0x00B,
        BPH8 = 0x00B, BPG8 = 0x00B, BPF8 = 0x00B, BPE8 = 0x00B, BPD8 = 0x00B, BPC8 = 0x00B, BPB8 = 0x00B, BPA8 = 0x00B,
        
        GFH1 = 0x00B, GFG1 = 0x00B, GFF1 = 0x00B, GFE1 = 0x00B, GFD1 = 0x00B, GFC1 = 0x00B, GFB1 = 0x00B, GFA1 = 0x00B,
        GFH2 = 0x00B, GFG2 = 0x00B, GFF2 = 0x00B, GFE2 = 0x00B, GFD2 = 0x00B, GFC2 = 0x00B, GFB2 = 0x00B, GFA2 = 0x00B,
        GFH3 = 0x00B, GFG3 = 0x00B, GFF3 = 0x00B, GFE3 = 0x00B, GFD3 = 0x00B, GFC3 = 0x00B, GFB3 = 0x00B, GFA3 = 0x00B,
        GFH4 = 0x00B, GFG4 = 0x00B, GFF4 = 0x00B, GFE4 = 0x00B, GFD4 = 0x00B, GFC4 = 0x00B, GFB4 = 0x00B, GFA4 = 0x00B,
        GFH5 = 0x00B, GFG5 = 0x00B, GFF5 = 0x00B, GFE5 = 0x00B, GFD5 = 0x00B, GFC5 = 0x00B, GFB5 = 0x00B, GFA5 = 0x00B,
        GFH6 = 0x00B, GFG6 = 0x00B, GFF6 = 0x00B, GFE6 = 0x00B, GFD6 = 0x00B, GFC6 = 0x00B, GFB6 = 0x00B, GFA6 = 0x00B,
        GFH7 = 0x00B, GFG7 = 0x00B, GFF7 = 0x00B, GFE7 = 0x00B, GFD7 = 0x00B, GFC7 = 0x00B, GFB7 = 0x00B, GFA7 = 0x00B,
        GFH8 = 0x00B, GFG8 = 0x00B, GFF8 = 0x00B, GFE8 = 0x00B, GFD8 = 0x00B, GFC8 = 0x00B, GFB8 = 0x00B, GFA8 = 0x00B,
        
        RFH1 = 0x00B, RFG1 = 0x00B, RFF1 = 0x00B, RFE1 = 0x00B, RFD1 = 0x00B, RFC1 = 0x00B, RFB1 = 0x00B, RFA1 = 0x00B,
        RFH2 = 0x00B, RFG2 = 0x00B, RFF2 = 0x00B, RFE2 = 0x00B, RFD2 = 0x00B, RFC2 = 0x00B, RFB2 = 0x00B, RFA2 = 0x00B,
        RFH3 = 0x00B, RFG3 = 0x00B, RFF3 = 0x00B, RFE3 = 0x00B, RFD3 = 0x00B, RFC3 = 0x00B, RFB3 = 0x00B, RFA3 = 0x00B,
        RFH4 = 0x00B, RFG4 = 0x00B, RFF4 = 0x00B, RFE4 = 0x00B, RFD4 = 0x00B, RFC4 = 0x00B, RFB4 = 0x00B, RFA4 = 0x00B,
        RFH5 = 0x00B, RFG5 = 0x00B, RFF5 = 0x00B, RFE5 = 0x00B, RFD5 = 0x00B, RFC5 = 0x00B, RFB5 = 0x00B, RFA5 = 0x00B,
        RFH6 = 0x00B, RFG6 = 0x00B, RFF6 = 0x00B, RFE6 = 0x00B, RFD6 = 0x00B, RFC6 = 0x00B, RFB6 = 0x00B, RFA6 = 0x00B,
        RFH7 = 0x00B, RFG7 = 0x00B, RFF7 = 0x00B, RFE7 = 0x00B, RFD7 = 0x00B, RFC7 = 0x00B, RFB7 = 0x00B, RFA7 = 0x00B,
        RFH8 = 0x00B, RFG8 = 0x00B, RFF8 = 0x00B, RFE8 = 0x00B, RFD8 = 0x00B, RFC8 = 0x00B, RFB8 = 0x00B, RFA8 = 0x00B */
    }
    
    namespace Structure
    {
        public class PiecePosition
        {
            int[] initial = 
            {
                0011, 0045, 0076, 0105, 0138, 0172, 0205, 0235,
                0270, 0302, 0334, 0366, 0398, 0430, 0462, 0494,
                1558, 1590, 1622, 1654, 1686, 1718, 1750, 1782,
                1811, 1845, 1876, 1905, 1938, 1972, 2005, 2035
            };

            public List<int> Items { private set; get; }

            public PiecePosition()
            {
                Items = new List<int>();
            }
            public void Remove(int square)
            {
                //if (Items.Any(p => ((p >> 5) & 63) == square))
                    Items.RemoveAll(p => ((p >> 5) & 63) == square);
            }
            public void Add(int figure)
            {
                Remove((figure >> 5) & 63);
                Items.Add(figure);
            }
            public void Add(List<int> position)
            {
                Items = new List<int>();
                foreach (int pos in position)
                    Items.Add(pos);
            }
            public void Initialize()
            {
                Items = new List<int>();
                foreach (int pos in initial)
                    Items.Add(pos);
            }
            public void Clear()
            {
                Items = new List<int>();
            }
        }
        public class FieldPosition
        {
            public List<int> Items { private set; get; }
            public FieldPosition()
            {
                Items = new List<int>();
            }
            public void Remove(int square)
            {
                //if (Items.Any(f => ((f >> 2) & 63) == square))
                    Items.RemoveAll(f => ((f >> 2) & 63) == square);
            }
            public void Add(int item)
            {
                Remove((item >> 2) & 63);
                Items.Add(item);
            }
            public void Add(List<int> position)
            {
                foreach (int pos in position)
                {
                    Remove((pos >> 2) & 63);
                    Items.Add(pos);
                }
            }
            public void Clear()
            {
                Items = new List<int>();
            }
        }
        public class ArrowPosition
        {
            public List<int> Items { get; private set; }
            public ArrowPosition()
            {
                Items = new List<int>();
            }
            public void Remove(int from, int to)
            {
                //if (Items.Any(f => ((f >> 2) & 63) == from))
                    Items.RemoveAll(f => ((f >> 2) & 63) == from && ((f >> 8) & 63) == to);
            }
            public void Add(int item)
            {
                int from = (item >> 2) & 63;
                int to = (item >> 8) & 63;
                Remove(from, to);
                Items.Add(item);
            }
            public void Clear()
            {
                Items = new List<int>();
            }
        }
        public class AlphaMenuItems
        {
            private int figure;
            public AlphaMenuItems(Point mouse)
            {
                int x = mouse.X / 60;
                int y = mouse.Y / 60;
                int coloration = 8 + x * 8;
                int piece = 1 + y;
                figure = coloration + piece;
            }
            public int Figure { get { return figure; } }
        }
        public class AlphaBoardClick
        {
            private int _x;
            private int _y;
            private int _index;
            private int square;
            public AlphaBoardClick(Point mouse)
            {
                _x = mouse.X / 60;
                _y = mouse.Y / 60;
                _index = _x + _y << 3;
            }
            public int X { get { return _x; } }
            public int Y { get { return _y; } }
        }
    }
    namespace Painting
    {
        public class PiecePaint
        {
            private Point[] area;
            private IPieceStyle style;
            public PiecePaint(IPieceStyle style)
            {
                this.style = style;
                area = new Point[64];
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        area[63 - ((i << 3) + j)] = new Point(j * this.style.SquareSize(), i * this.style.SquareSize());
                    }
                }
            }
            public Bitmap DrawPosition(List<int> position)
            {
                Bitmap b = new Bitmap(8 * this.style.SquareSize(), 8 * this.style.SquareSize());
                b.MakeTransparent();
                using (Graphics g = Graphics.FromImage(b))
                {
                    foreach (var pos in position)
                    {
                        Bitmap piece = this.style.Image(pos);
                        Point square = area[(pos >> 5) & 63];
                        g.DrawImage(piece, square);
                    }
                }
                return b;
            }
        }
        public class FieldPaint
        {
            private Point[] area;
            private IFieldStyle style;
            public FieldPaint(IFieldStyle style)
            {
                this.style = style;
                area = new Point[64];
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        area[63 - ((i << 3) + j)] = new Point(j * this.style.Size(), i * this.style.Size());
                    }
                }
            }
            public Bitmap DrawFields(List<int> items)
            {
                Bitmap b = new Bitmap(8 * this.style.Size(), 8 * this.style.Size());
                b.MakeTransparent();
                using (Graphics g = Graphics.FromImage(b))
                {
                    foreach (var f in items)
                    {
                        Bitmap field = this.style.Image(f);
                        Point square = area[(f >> 2) & 63];
                        g.DrawImage(field, square);
                    }
                }
                return b;
            }
        }
        public class ArrowPaint
        {
            private Point[] area;
            private IFieldStyle style;
            public ArrowPaint(IFieldStyle style)
            {
                this.style = style;
                area = new Point[64];
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        int x = j * this.style.Size() + this.style.Size() / 2;
                        int y = i * this.style.Size() + this.style.Size() / 2;
                        area[63 - ((i << 3) + j)] = new Point(x, y);
                    }
                }
            }
            public Bitmap DrawArrows(List<int> items)
            {
                Bitmap b = new Bitmap(8 * this.style.Size(), 8 * this.style.Size());
                b.MakeTransparent();
                Color coloration = Color.FromArgb(255, 0, 0, 0);
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    foreach (var f in items)
                    {
                        switch (f & 3)
                        {
                            case 1: coloration = Color.FromArgb(200, 155, 45, 48); break;
                            case 2: coloration = Color.FromArgb(200, 0, 145, 110); break;
                            case 3: coloration = Color.FromArgb(200, 20, 100, 190); break;
                        };
                        Pen pen = new Pen(coloration, 6);
                        pen.CustomEndCap = new AdjustableArrowCap(3, 4);
                        g.DrawLine(pen, area[(f >> 2) & 63], area[(f >> 8) & 63]);
                    }
                }
                return b;
            }
        }
        public class LayerPaint 
        {
            private Bitmap b;
            public LayerPaint(Bitmap fieldLayer, Bitmap pieceLayer, Bitmap arrowLayer)
            {
                this.b = new Bitmap(fieldLayer.Width, fieldLayer.Height);
                b.MakeTransparent();
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.DrawImage(fieldLayer, new Point());
                    g.DrawImage(pieceLayer, new Point());
                    g.DrawImage(arrowLayer, new Point());
                }
            }
            public LayerPaint(Bitmap fieldLayer, Bitmap pieceLayer)
            {
                this.b = new Bitmap(fieldLayer.Width, fieldLayer.Height);
                b.MakeTransparent();
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.DrawImage(fieldLayer, new Point());
                    g.DrawImage(pieceLayer, new Point());
                }
            }
            public LayerPaint(Bitmap pieceLayer)
            {
                this.b = new Bitmap(pieceLayer.Width, pieceLayer.Height);
                b.MakeTransparent();
                using (Graphics g = Graphics.FromImage(b)) 
                    g.DrawImage(pieceLayer, new Point());
            }
            public Bitmap Image()
            {
                return b;
            }
        }

        public class AlphaMenu
        {
            private ChessMenu _menu;
            private AlphaPieces _pieces;
            public Bitmap MenuImage { get; private set; }
            public AlphaMenu()
            {
                _menu = new ChessMenu();
                _pieces = new AlphaPieces();
                MenuImage = new Bitmap(120, 360);
                Graphics g = Graphics.FromImage(MenuImage);
                for (int i = 0; i < 2; i++)
                    for (int j = 0; j < 6; j++)
                        g.DrawImage(_menu.Cell, i * 60, j * 60);
                g.DrawImage(_pieces.Image(09), 00, 000);
                g.DrawImage(_pieces.Image(10), 00, 060);
                g.DrawImage(_pieces.Image(11), 00, 120);
                g.DrawImage(_pieces.Image(12), 00, 180);
                g.DrawImage(_pieces.Image(13), 00, 240);
                g.DrawImage(_pieces.Image(14), 00, 300);
                g.DrawImage(_pieces.Image(17), 60, 000);
                g.DrawImage(_pieces.Image(18), 60, 060);
                g.DrawImage(_pieces.Image(19), 60, 120);
                g.DrawImage(_pieces.Image(20), 60, 180);
                g.DrawImage(_pieces.Image(21), 60, 240);
                g.DrawImage(_pieces.Image(22), 60, 300);
            }
            public void Select(Point mouse)
            {
                Point click = new Point(mouse.X / 60, mouse.Y / 60);
                _menu = new ChessMenu();
                _pieces = new AlphaPieces();
                MenuImage = new Bitmap(120, 360);
                Graphics g = Graphics.FromImage(MenuImage);
                for (int i = 0; i < 2; i++)
                    for (int j = 0; j < 6; j++)
                        g.DrawImage(_menu.Cell, i * 60, j * 60);
                g.DrawImage(_menu.Selected, click.X * 60, click.Y * 60);
                g.DrawImage(_pieces.Image(09), 00, 000);
                g.DrawImage(_pieces.Image(10), 00, 060);
                g.DrawImage(_pieces.Image(11), 00, 120);
                g.DrawImage(_pieces.Image(12), 00, 180);
                g.DrawImage(_pieces.Image(13), 00, 240);
                g.DrawImage(_pieces.Image(14), 00, 300);
                g.DrawImage(_pieces.Image(17), 60, 000);
                g.DrawImage(_pieces.Image(18), 60, 060);
                g.DrawImage(_pieces.Image(19), 60, 120);
                g.DrawImage(_pieces.Image(20), 60, 180);
                g.DrawImage(_pieces.Image(21), 60, 240);
                g.DrawImage(_pieces.Image(22), 60, 300);
            }
        }
    }
}
