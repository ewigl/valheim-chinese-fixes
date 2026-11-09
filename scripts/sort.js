//
import { readFileSync, writeFileSync } from "fs";
import { dirname, join } from "path";
import { fileURLToPath } from "url";

const __dirname = dirname(fileURLToPath(import.meta.url));

const filePath = join(__dirname, "..", "Fixes", "Chinese.json");
const data = JSON.parse(readFileSync(filePath, "utf8"));

if (data === null || Array.isArray(data) || typeof data !== "object") {
  throw new TypeError("Fixes/Chinese.json must contain a JSON object.");
}

const sorted = Object.fromEntries(
  Object.entries(data).sort(([a], [b]) => a.localeCompare(b)),
);

writeFileSync(filePath, `${JSON.stringify(sorted, null, 2)}`, "utf8");
