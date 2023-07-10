namespace F1Sharp
{
    /// <summary>
    /// Array position of the wheels
    /// </summary>
    public enum Wheel : byte
    {
        /// <summary>
        /// Rear left
        /// </summary>
        RL = 0,
        /// <summary>
        /// Rear ruight
        /// </summary>
        RR = 1,
        /// <summary>
        /// Front left
        /// </summary>
        FL = 2,
        /// <summary>
        /// Front right
        /// </summary>
        FR = 3
    }

    /// <summary>
    /// Identifiers for the packets
    /// </summary>
    public enum Packet : byte
    {
        /// <summary>
        /// Contains all motion data for player’s car – only sent while player is in control
        /// </summary>
        MOTION = 0,
        /// <summary>
        /// Data about the session – track, time left
        /// </summary>
        SESSION = 1,
        /// <summary>
        /// Data about all the lap times of cars in the session
        /// </summary>
        LAP_DATA = 2,
        /// <summary>
        /// Various notable events that happen during a session
        /// </summary>
        EVENT = 3,
        /// <summary>
        /// List of participants in the session, mostly relevant for multiplayer
        /// </summary>
        PARTICIPANTS = 4,
        /// <summary>
        /// Packet detailing car setups for cars in the race
        /// </summary>
        CAR_SETUPS = 5,
        /// <summary>
        /// Telemetry data for all cars
        /// </summary>
        CAR_TELEMETRY = 6,
        /// <summary>
        /// Status data for all cars
        /// </summary>
        CAR_STATUS = 7,
        /// <summary>
        /// Final classification confirmation at the end of a race
        /// </summary>
        FINAL_CLASSIFICATION = 8,
        /// <summary>
        /// Information about players in a multiplayer lobby
        /// </summary>
        LOBBY_INFO = 9,
        /// <summary>
        /// Damage status for all cars
        /// </summary>
        CAR_DAMAGE = 10,
        /// <summary>
        /// Lap and tyre data for session
        /// </summary>
        SESSION_HISTORY = 11,
        /// <summary>
        /// Extended tyre set data
        /// </summary>
        TYRE_SET = 12,
        /// <summary>
        /// Extended motion data for player car
        /// </summary>
        MOTION_EX = 13
    }

    /// <summary>
    /// Identifiers for the tracks
    /// </summary>
    public enum Track : sbyte
    {
        UNKNOWN = -1,
        MELBOURNE = 0,
        PAUL_RICARD = 1,
        SHANGHAI = 2,
        SAKHIR = 3,
        CATALUNYA = 4,
        MONACO = 5,
        MONTREAL = 6,
        SILVERSTONE = 7,
        HOCKENHEIM = 8,
        HUNGARORING = 9,
        SPA = 10,
        MONZA = 11,
        SINGAPORE = 12,
        SUZUKA = 13,
        ABU_DHABI = 14,
        TEXAS = 15,
        BRAZIL = 16,
        AUSTRIA = 17,
        SOCHI = 18,
        MEXICO = 19,
        BAKU = 20,
        SAKHIR_SHORT = 21,
        SILVERSTONE_SHORT = 22,
        TEXAS_SHORT = 23,
        SUZUKA_SHORT = 24,
        HANOI = 25,
        ZANDVOORT = 26,
        IMOLA = 27,
        PORTIMAO = 28,
        JEDDAH = 29,
        MIAMI = 30,
        LAS_VEGAS = 31,
        LOSAIL = 32
    }

    /// <summary>
    /// Codes for the flags displayed
    /// </summary>
    public enum ZoneFlag : sbyte
    {
        /// <summary>
        /// Unknown or invalid flag
        /// </summary>
        UNKNOWN = -1,
        /// <summary>
        /// No flag
        /// </summary>
        NONE = 0,
        /// <summary>
        /// Green flag
        /// </summary>
        GREEN = 1,
        /// <summary>
        /// Blue flag
        /// </summary>
        BLUE = 2,
        /// <summary>
        /// Yellow flag
        /// </summary>
        YELLOW = 3
    }

    /// <summary>
    /// Codes for the type of the sessions
    /// </summary>
    public enum Session : byte
    {
        /// <summary>
        ///  Unknown
        /// </summary>
        UNKNOWN = 0,
        /// <summary>
        /// Practice 1
        /// </summary>
        P1 = 1,
        /// <summary>
        /// Practice 2
        /// </summary>
        P2 = 2,
        /// <summary>
        /// Practice 3
        /// </summary>
        P3 = 3,
        /// <summary>
        /// Short practice
        /// </summary>
        SP = 4,
        /// <summary>
        /// Qualifying 1
        /// </summary>
        Q1 = 5,
        /// <summary>
        /// Qualifying 2
        /// </summary>
        Q2 = 6,
        /// <summary>
        /// Qualifying 3
        /// </summary>
        Q3 = 7,
        /// <summary>
        /// Short qualifying
        /// </summary>
        SQ = 8,
        /// <summary>
        /// One shot qualifying
        /// </summary>
        OSQ = 9,
        /// <summary>
        /// Race
        /// </summary>
        R = 10,
        /// <summary>
        /// Sprint race
        /// </summary>
        R1 = 11,
        /// <summary>
        /// Race (after sprint)
        /// </summary>
        R2 = 12,
        /// <summary>
        /// Time trial
        /// </summary>
        TT = 13
    }

    /// <summary>
    /// Codes for the weather
    /// </summary>
    public enum Weather : byte
    {
        /// <summary>
        /// Clear skies
        /// </summary>
        CLEAR = 0,
        /// <summary>
        /// Light clouds
        /// </summary>
        LIGHT_CLOUD = 1,
        /// <summary>
        /// Overcast
        /// </summary>
        OVERCAST = 2,
        /// <summary>
        /// Light rain
        /// </summary>
        LIGHT_RAIN = 3,
        /// <summary>
        /// Heavy rain
        /// </summary>
        HEAVY_RAIN = 4,
        /// <summary>
        /// Storm
        /// </summary>
        STORM = 5
    }

    /// <summary>
    /// Codes for the car types
    /// </summary>
    public enum Formula : byte
    {
        /// <summary>
        /// Modern F1 cars
        /// </summary>
        F1_MODERN = 0,
        /// <summary>
        /// Classic F1 cars
        /// </summary>
        F1_CLASSIC = 1,
        /// <summary>
        /// F2 cars
        /// </summary>
        F2 = 2,
        /// <summary>
        /// Generic F1
        /// </summary>
        F1_GENERIC = 3,
        /// <summary>
        /// Beta
        /// </summary>
        BETA = 4,
        /// <summary>
        /// Supercars
        /// </summary>
        SUPERCARS = 5,
        /// <summary>
        /// ESports cars
        /// </summary>
        ESPORTS = 6,
        /// <summary>
        /// F2 2021 cars
        /// </summary>
        F2_2021 = 7
    }

    /// <summary>
    /// Status code for the Safety Car
    /// </summary>
    public enum SafetyCarStatus : byte
    {
        /// <summary>
        /// None
        /// </summary>
        NONE = 0,
        /// <summary>
        /// Safety car period
        /// </summary>
        FULL = 1,
        /// <summary>
        /// Virtual safety car period
        /// </summary>
        VSC = 2,
        /// <summary>
        /// Formation lap
        /// </summary>
        FORMATION_LAP = 3
    }

    /// <summary>
    /// Identifiers for the game modes
    /// </summary>
    public enum GameMode : byte
    {
        EVENT_MODE = 0,
        GRAND_PRIX = 3,
        TIME_TRIAL = 5,
        SPLITSCREEN = 6,
        ONLINE_CUSTOM = 7,
        ONLINE_LEAGUE = 8,
        CAREER_INVITATIONAL = 11,
        CHAMPIONSHIP_INVITATIONAL = 12,
        CHAMPIONSHIP = 13,
        ONLINE_CHAMPIONSHIP = 14,
        ONLINE_WEEKLY_EVENT = 15,
        CAREER_22 = 19,
        CAREER_22_ONLINE = 20,
        BENCHMARK = 127
    }

    /// <summary>
    /// Identifiers for the rule sets
    /// </summary>
    public enum RuleSet : byte
    {
        PRACTICE_QUALIFYING = 0,
        RACE = 1,
        TIME_TRIAL = 2,
        TIME_ATTACK = 4,
        CHECKPOINT_CHALLENGE = 6,
        AUTOCROSS = 8,
        DRIFT = 9,
        AVERAGE_SPEED_ZONE = 10,
        RIVAL_DUEL = 11
    }

    /// <summary>
    /// Identifiers for the session length
    /// </summary>
    public enum SessionLength : byte
    {
        NONE = 0,
        /// <summary>
        /// 3 laps
        /// </summary>
        VERY_SHORT = 2,
        /// <summary>
        /// 5 laps
        /// </summary>
        SHORT = 3,
        /// <summary>
        /// 25%
        /// </summary>
        MEDIUM = 4,
        /// <summary>
        /// 35%
        /// </summary>
        MEDIUM_LONG = 5,
        /// <summary>
        /// 50%
        /// </summary>
        LONG = 6,
        /// <summary>
        /// 100%
        /// </summary>
        FULL = 7
    }

    /// <summary>
    /// Identifiers for the speed units
    /// </summary>
    public enum SpeedUnit : byte
    {
        /// <summary>
        /// Miles per hour
        /// </summary>
        MPH = 0,
        /// <summary>
        /// Kilometers per hour
        /// </summary>
        KPH = 1
    }

    /// <summary>
    /// Identifier for the temperature units
    /// </summary>
    public enum TemperatureUnit : byte
    {
        /// <summary>
        /// Celsius
        /// </summary>
        CELSIUS = 0,
        /// <summary>
        /// Fahrenheit
        /// </summary>
        FAHRENHEIT = 1
    }

    /// <summary>
    /// Identifier for the sectors
    /// </summary>
    public enum Sector : byte
    {
        /// <summary>
        /// Sector 1
        /// </summary>
        SECTOR1 = 0,
        /// <summary>
        /// Sector 2
        /// </summary>
        SECTOR2 = 1,
        /// <summary>
        /// Sector 3
        /// </summary>
        SECTOR3 = 2
    }

    /// <summary>
    /// Identifier for the status of the driver
    /// </summary>
    public enum DriverStatus : byte
    {
        /// <summary>
        /// In garage
        /// </summary>
        IN_GARAGE = 0,
        /// <summary>
        /// Flying lap
        /// </summary>
        FLYING_LAP = 1,
        /// <summary>
        /// In lap
        /// </summary>
        IN_LAP = 2,
        /// <summary>
        /// Out lap
        /// </summary>
        OUT_LAP = 3,
        /// <summary>
        /// On track
        /// </summary>
        ON_TRACK = 4
    }

    /// <summary>
    /// Identifier for the result status
    /// </summary>
    public enum ResultStatus : byte
    {
        /// <summary>
        /// Invalid
        /// </summary>
        INVALID = 0,
        /// <summary>
        /// Inactive
        /// </summary>
        INACTIVE = 1,
        /// <summary>
        /// Active
        /// </summary>
        ACTIVE = 2,
        /// <summary>
        /// Finished
        /// </summary>
        FINISHED = 3,
        /// <summary>
        /// Did not finish
        /// </summary>
        DNF = 4,
        /// <summary>
        /// Disqualified
        /// </summary>
        DSQ = 5,
        /// <summary>
        /// Not qualified
        /// </summary>
        NOT_QUALIFIED = 6,
        /// <summary>
        /// Retired
        /// </summary>
        RETIRED = 7
    }

    /// <summary>
    /// Identifier for the pit status
    /// </summary>
    public enum PitStatus : byte
    {
        /// <summary>
        /// Not in the pits
        /// </summary>
        NONE = 0,
        /// <summary>
        /// Pitting
        /// </summary>
        PITTING = 1,
        /// <summary>
        /// In pit area
        /// </summary>
        IN_PIT_AREA = 2
    }

    /// <summary>
    /// Identifier for the penalty types
    /// </summary>
    public enum PenaltyType : byte
    {
        /// <summary>
        /// Drive through
        /// </summary>
        DRIVE_THROUGH = 0,
        /// <summary>
        /// Stop &amp; go
        /// </summary>
        STOP_GO = 1,
        /// <summary>
        /// Grid penalty
        /// </summary>
        GRID_PENALTY = 2,
        /// <summary>
        /// Penalty reminder
        /// </summary>
        PENALTY_REMINDER = 3,
        /// <summary>
        /// Time penalty
        /// </summary>
        TIME_PENALTY = 4,
        /// <summary>
        /// Warning
        /// </summary>
        WARNING = 5,
        /// <summary>
        /// Disqualified
        /// </summary>
        DISQUALIFIED = 6,
        /// <summary>
        /// Removed from formation lap
        /// </summary>
        REMOVED_FROM_FL = 7,
        /// <summary>
        /// Parked too long timer
        /// </summary>
        PARKED_TOO_LONG_TIMER = 8,
        /// <summary>
        /// Tyre regulations
        /// </summary>
        TYRE_REGULATIONS = 9,
        /// <summary>
        /// This lap invalidated
        /// </summary>
        THIS_LAP_INVALIDATED = 10,
        /// <summary>
        /// This and next lap invalidated
        /// </summary>
        THIS_AND_NEXT_LAP_INVALIDATED = 11,
        /// <summary>
        /// This lap invalidated without reason
        /// </summary>
        THIS_LAP_INVALIDATED_WITHOUT_REASON = 12,
        /// <summary>
        /// This and next lap invalidated without reason
        /// </summary>
        THIS_AND_NEXT_LAP_INVALIDATED_WITHOUT_REASON = 13,
        /// <summary>
        /// This and previous lap invalidated
        /// </summary>
        THIS_AND_PREVIOUS_LAP_INVALIDATED = 14,
        /// <summary>
        /// This and previous lap invalidated wihout reason
        /// </summary>
        THIS_AND_PREVIOUS_LAP_INVALIDATED_WITHOUT_REASON = 15,
        /// <summary>
        /// Retired
        /// </summary>
        RETIRED = 16,
        /// <summary>
        /// Black flag timer
        /// </summary>
        BLACK_FLAG_TIMER = 17
    }

    /// <summary>
    /// Identifier for infringement type
    /// </summary>
    public enum InfringementType : byte
    {
        BLOCKING_SLOW_DRIVING = 0,
        BLOCKING_WRONG_WAY = 1,
        REVERSING_START_LINE = 2,
        BIG_COLLISION = 3,
        SMALL_COLLISION = 4,
        FAILED_TO_HAND_BACK_POSITION_SINGLE = 5,
        FAILED_TO_HAND_BACK_POSITION_MULTIPLE = 6,
        CORNER_CUTTING_GAINED_TIME = 7,
        CORNER_CUTTING_OVERTAKE_SINGLE = 8,
        CORNER_CUTTING_OVERTAKE_MULTIPLE = 9,
        CROSSED_PIT_EXIT_LANE = 10,
        IGNORING_BLUE_FLAGS = 11,
        IGNORING_YELLOW_FLAGS = 12,
        IGNORING_DRIVE_THROUGH = 13,
        TOO_MANY_DRIVE_THROUGHS = 14,
        DRIVE_THROUGH_REMINDER_SERVE_WITHING = 15,
        DRIVE_THROUGH_REMINDER_SERVE_NOW = 16,
        PIT_LANE_SPEEDING = 17,
        PARKED_FOR_TOO_LONG = 18,
        IGNORING_TYRE_REGULATIONS = 19,
        TOO_MANY_PENALTIES = 20,
        MULTIPLE_WARNINGS = 21,
        APPROACHING_DISQUALIFICATION = 22,
        TYRE_REGULATIONS_SELECT_SINGLE = 23,
        TYRE_REGULATIONS_SELECT_MULTIPLE = 24,
        LAP_INVALIDATED_CORNER_CUTTING = 25,
        LAP_INVALIDATED_RUNNING_WIDE = 26,
        CORNER_CUTTING_RAN_WIDE_GAINED_TIME_MINOR = 27,
        CORNER_CUTTING_RAN_WIDE_GAINED_TIME_SIGNIFICANT = 28,
        CORNER_CUTTING_RAN_WIDE_GAINED_TIME_EXTREME = 29,
        LAP_INVALIDATED_WALL_RIDING = 30,
        LAP_INVALIDATED_FLASHBACK_USED = 31,
        LAP_INVALIDATED_RESET_TO_TRACK = 32,
        BLOCKING_PITLANE = 33,
        JUMP_START = 34,
        SAFETY_CAR_COLLISION = 35,
        SAFETY_CAR_ILLEGAL_OVERTAKE = 36,
        SAFETY_CAR_EXCEEDING_PACE = 37,
        VIRTUAL_SAFETY_CAR_EXCEEDING_PACE = 38,
        FORMATION_LAP_SLOW = 39,
        FORMATION_LAP_PARKING = 40,
        RETIRED_MECHANICAL_FAILURE = 41,
        RETIRED_TERMINALLY_DAMAGED = 42,
        SAFETY_CAR_FALLING_TOO_FAR_BACK = 43,
        BLACK_FLAG_TIMER = 44,
        UNSERVED_STOP_GO = 45,
        UNSERVED_DRIVE_THROUGH = 46,
        ENGINE_COMPONENT_CHANGE = 47,
        GEARBOX_CHANGE = 48,
        PARC_FERME_CHANGE = 49,
        LEAGUE_GRID_PENALTY = 50,
        RETRY_PENALTY = 51,
        ILLEGAL_TIME_GAIN = 52,
        MANDATORY_PIT_STOP = 53,
        ATTRIBUTE_ASSIGNED = 54
    }

    /// <summary>
    /// These flags are used in the telemetry packet to determine if any buttons are being held on the controlling device.
    /// If the value below logical ANDed with the button status is set then the corresponding button is being held.
    /// </summary>
    public enum Button : uint
    {
        CROSS_OR_A = 0x00000001,
        TRIANGLE_OR_Y = 0x00000002,
        CIRCLE_OR_B = 0x00000004,
        SQUARE_OR_X = 0x00000008,
        DPAD_LEFT = 0x00000010,
        DPAD_RIGHT = 0x00000020,
        DPAD_UP = 0x00000040,
        DPAD_DOWN = 0x00000080,
        OPTIONS_OR_MENU = 0x00000100,
        L1_OR_LB = 0x00000200,
        R1_OR_RB = 0x00000400,
        L2_OR_LT = 0x00000800,
        R2_OR_RT = 0x00001000,
        LEFT_STICK_CLICK = 0x00002000,
        RIGHT_STICK_CLICK = 0x00004000,
        RIGHT_STICK_LEFT = 0x00008000,
        RIGHT_STICK_RIGHT = 0x00010000,
        RIGHT_STICK_UP = 0x00020000,
        RIGHT_STICK_DOWN = 0x00040000,
        SPECIAL = 0x00080000,
        UDP_ACTION_1 = 0x00100000,
        UDP_ACTION_2 = 0x00200000,
        UDP_ACTION_3 = 0x00400000,
        UDP_ACTION_4 = 0x00800000,
        UDP_ACTION_5 = 0x01000000,
        UDP_ACTION_6 = 0x02000000,
        UDP_ACTION_7 = 0x04000000,
        UDP_ACTION_8 = 0x08000000,
        UDP_ACTION_9 = 0x10000000,
        UDP_ACTION_10 = 0x20000000,
        UDP_ACTION_11 = 0x40000000,
        UDP_ACTION_12 = 0x80000000
    }

    /// <summary>
    /// Identifier for the player's platform
    /// </summary>
    public enum Platform : byte
    {
        STEAM = 1,
        PLAYSTATION = 3,
        XBOX = 4,
        ORIGIN = 6,
        UNKNOWN = 255
    }

    /// <summary>
    /// Identifier for MFD panel position
    /// </summary>
    public enum MfdPanelIndex : byte
    {
        CLOSED = 255,
        CAR_SETUP = 0,
        PITS = 1,
        DAMAGE = 2,
        ENGINE = 3,
        TEMPERATURES = 4
    }

    /// <summary>
    /// Identifier for surface types
    /// </summary>
    public enum SurfaceType : byte
    {
        TARMAC = 0,
        RUMBLE_STRIP = 1,
        CONCRETE = 2,
        ROCK = 3,
        GRAVEL = 4,
        MUD = 5,
        SAND = 6,
        GRASS = 7,
        WATER = 8,
        COBBLESTONE = 9,
        METAL = 10,
        RIDGED = 11
    }

    /// <summary>
    /// Actual tyre compounds
    /// </summary>
    public enum TyreCompound : byte
    {
        C5 = 16,
        C4 = 17,
        C3 = 18,
        C2 = 19,
        C1 = 20,
        C0 = 21,
        INTER = 7,
        WET = 8,
        CLASSIC_DRY = 9,
        CLASSIC_WET = 10,
        F2_SUPER_SOFT = 11,
        F2_SOFT = 12,
        F2_MEDIUM = 13,
        F2_HARD = 14,
        F2_WET = 15
    }

    /// <summary>
    /// Visual tyre compound
    /// </summary>
    public enum VisualTyreCompound : byte
    {
        SOFT = 16,
        MEDIUM = 17,
        HARD = 18,
        INTER = 7,
        WET = 8,
        CLASSIC_DRY = 9,
        CLASSIC_WET = 10,
        F2_WET = 15,
        F2_SUPER_SOFT = 19,
        F2_SOFT = 20,
        F2_MEDIUM = 21,
        F2_HARD = 22
    }
}