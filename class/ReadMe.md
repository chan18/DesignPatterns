| **Relationship** | **Type**     | **Code Keyword** | **Ownership**   | **Example**                |
| ---------------- | ------------ | ---------------- | --------------- | -------------------------- |
| Inheritance      | "is-a"       | `:`              | Shared          | `Dog : Animal`             |
| Association      | "has-a"      | field/property   | Independent     | `Company -> Person`        |
| Aggregation      | "whole-part" | List/collection  | Weak (shared)   | `University -> Department` |
| Composition      | "whole-part" | new instance     | Strong (owned)  | `Car -> Engine`            |
| Dependency       | "uses"       | method param     | Temporary/Loose | `Service -> Logger`        |
| Implementation   | "implements" | `: Interface`    | Contractual     | `Printer : IPrintable`     |
