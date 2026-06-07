# Okta UKG Workforce Role Risk Map

Workforce role risk map for Okta role assignments, UKG job codes, and manager-safe attestations.

![ci](https://github.com/mizcausevic-dev/okta-ukg-workforce-role-risk-map/actions/workflows/ci.yml/badge.svg)

## Why this exists

This is a Kinetic Gain signal surface for Okta, UKG. It turns fragmented operational facts into board-ready questions:

- Where are we exposed?
- Where can we save money?
- Where should we invest?
- What story do we tell with evidence?

## Signal lanes

- termination lag
- role mismatch
- stale application access
- manager attestation
- privilege exceptions
- license waste

## Stack signal

- Primary language signal: C#
- Vertical: IAM / Security / HR Tech
- Portfolio family: Okta + UKG
- Live surface: https://mizcausevic-dev.github.io/okta-ukg-workforce-role-risk-map/

## Local verification

~~~bash
npm test
~~~

The validation script checks the generated evidence payload and confirms the static board surface exists.
