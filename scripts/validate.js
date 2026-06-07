const fs = require('fs');
const path = require('path');

const evidencePath = path.join(__dirname, '..', 'data', 'signals.json');
const pagePath = path.join(__dirname, '..', 'docs', 'index.html');
const evidence = JSON.parse(fs.readFileSync(evidencePath, 'utf8'));
const page = fs.readFileSync(pagePath, 'utf8');

const requiredPlatforms = ["Okta","UKG"];
const requiredSignals = ["termination lag","role mismatch","stale application access"];

for (const platform of requiredPlatforms) {
  if (!evidence.platforms.includes(platform) || !page.includes(platform)) {
    throw new Error('Missing platform signal: ' + platform);
  }
}

for (const signal of requiredSignals) {
  if (!evidence.signals.some((entry) => entry.lane === signal) || !page.includes(signal)) {
    throw new Error('Missing evidence lane: ' + signal);
  }
}

if (!page.includes('Where are we exposed')) {
  throw new Error('Missing board question framing');
}

console.log('okta-ukg-workforce-role-risk-map: validation passed');
